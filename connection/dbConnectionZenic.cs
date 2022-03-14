using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using PassOrganiser.Entities;


namespace PassOrganiser.connection
{
    public class dbConnectionZenic
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public dbConnectionZenic()
        {
            Initialize();
        }

        /// <summary>
        /// Constructs the connection string and initialize the connection.
        /// </summary>
        private void Initialize()
        {
            server = System.Environment.GetEnvironmentVariable("server", EnvironmentVariableTarget.Machine);
            database = "mazilu_si_asociatii";
            uid = System.Environment.GetEnvironmentVariable("UID", EnvironmentVariableTarget.Machine);
            password = System.Environment.GetEnvironmentVariable("password", EnvironmentVariableTarget.Machine);

            string connectionString = "SERVER=" + server + ";" + 
                                      "DATABASE=" + database + ";" + 
                                      "UID=" + uid + ";" + 
                                      "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Opens a MySql connection.
        /// </summary>
        /// <returns>bool</returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch ( MySqlException ex )
            {
                switch ( ex.Number )
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Closes the MySql connection.
        /// </summary>
        /// <returns>bool</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch ( MySqlException ex )
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Persists in the database the object creted by the values from the form fields
        /// </summary>
        /// <param name="query">string "query"</param>
        /// <returns>void</returns>
        public void Insert( string query )
        {
            if ( this.OpenConnection() == true )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Select a Cont object based of the provided id
        /// </summary>
        /// <param name="id">long id</param>
        /// <returns>Cont object</returns>
        public Cont SelectCont( long id )
        {
            string query = "SELECT * FROM conturi WHERE id = " + id + ";";
            Cont editCont = new Cont();
            if ( this.OpenConnection() == true )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while ( dr.Read() )
                {
                    editCont.id = long.Parse(dr[ "id" ].ToString());
                    editCont.userName = dr[ "username" ].ToString();
                    editCont.password = dr[ "password" ].ToString();
                    editCont.categorie = dr[ "categorie" ].ToString();
                    editCont.description = dr[ "description" ].ToString();
                }
                this.CloseConnection();
            }

            return editCont;
        }

        /// <summary>
        /// Updates the selected object in the database
        /// </summary>
        /// <param name="query"></param>
        /// <returns>void</returns>
        public void Update( string query )
        {
            if ( this.OpenConnection() == true )
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;

                string message = cmd.ExecuteNonQuery() > 0 ? "Inregistrare editata cu succes" : "Editare esuata";
                MessageBox.Show(message);
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the selected object
        /// </summary>
        /// <param name="query"></param>
        /// <returns>void</returns>
        public void Delete( string query )
        {
            if ( this.OpenConnection() == true )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// Returns a list with all the objects from the database
        /// </summary>
        /// <returns>a list of Cont objects</returns>
        public string  SelectAll()
        {
            var dosareJson = "";
            List<Dosare> dosare = new List<Dosare>();
            if ( this.OpenConnection() == true )
            {
                string query = "SELECT dosare.id, " +
                               "dosare.id_debitor, " +
                               "dosare.id_creditor, " +
                               "dosare.nr_dosar, " +
                               "dosare.titlu_executoriu, " +
                               "persoane.persoana AS creditor, " +
                               "persoane.adresa_formatata AS adresa_creditor, " +
                               "persoane_1.persoana AS debitor, " +
                               "persoane_1.cif_cnp AS d_cif_cnp, " +
                               "persoane_1.adresa_formatata AS adresa_debitor " +
                               "FROM dosare " +
                               "LEFT OUTER JOIN persoane persoane_1 ON dosare.id_debitor = persoane_1.id " +
                               "LEFT OUTER JOIN persoane ON persoane.id = dosare.id_creditor " +
                               "WHERE (dosar_finalizat IN (0, 4)) AND (notificare = 0) ORDER BY ordonare_dosare DESC LIMIT 200;";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while ( dataReader.Read() )
                {
                    dosare.Add(new Dosare(
                        dataReader["id"].ToString(),
                        dataReader["id_debitor"].ToString(),
                        dataReader["id_creditor"].ToString(),
                        dataReader["nr_dosar"].ToString(),
                        dataReader["creditor"].ToString(),
                        dataReader["adresa_creditor"].ToString(),
                        dataReader["debitor"].ToString(),
                        dataReader["d_cif_cnp"].ToString(),
                        dataReader["adresa_debitor"].ToString(),
                        dataReader["titlu_executoriu"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                dosareJson = JsonConvert.SerializeObject(dosare);
            }
            return dosareJson;
        }

        /// <summary>
        /// Search by a provided string and returns a collection of matching objects.
        /// Takes a query string wich contains the searching string from the searching filed in the winform.
        /// </summary>
        /// <param name="query">string query</param>
        /// <returns>a list of object that match the search criteria</returns>
        public List<Cont> Search( string query )
        {
            List<Cont> searchList = new List<Cont>();
            if ( this.OpenConnection() == true )
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while ( dataReader.Read() )
                {
                    searchList.Add(new Cont(
                                        long.Parse(dataReader[ "id" ].ToString()),
                                             dataReader[ "categorie" ].ToString(),
                                              dataReader[ "username" ].ToString(),
                                              dataReader[ "password" ].ToString(),
                                            dataReader[ "description" ].ToString())
                                        );
                }
                dataReader.Close();
                this.CloseConnection();
                return searchList;
            }
            return searchList;
        }

        /// <summary>
        /// Verify if the values from fields corresponds to a user in database.
        /// Returns true if user exists, or false if doesn't
        /// </summary>
        /// <param name="username">string - username</param>
        /// <param name="pass">string - password</param>
        /// <returns>bool</returns>
        public bool VerifyLoginFields( string username, string pass )
        {
            MySqlDataReader dataReader;
            string query = $"SELECT * FROM users WHERE " +
                           $" username = '{username}' " +
                           $" AND password = '{pass}';";
            try
            {
                if ( CloseConnection() )
                {
                    connection.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                dataReader = cmd.ExecuteReader();
                if ( dataReader.HasRows )
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch ( MySqlException ex )
            {
                MessageBox.Show("Username sau password gresite. Please try again");
                return false;
            }
            dataReader.Close();
            this.CloseConnection();
        }
        /// <summary>
        /// Fastline is a concept of introducing a predefined format of different values separated by a predefined character. 
        /// Verify if the value from field about username and password are contained in the database.
        /// Tha values for username and password come in single string separated by a "space"."
        /// Returns true if user exists, or false if doesn't.
        /// </summary>
        /// <param name="fastline"> strig containing username and password separated by a "space"</param>
        /// <returns>bool</returns>
        public bool VerifyLoginFastLine( string fastline )
        {
            MySqlDataReader dataReader;
            string[ ] connCredentials = fastline.Split(" ");
            string username = connCredentials[ 0 ].Trim().ToLower();
            string pass = connCredentials[ 1 ].Trim().ToLower();

            return VerifyLoginFields(username, pass);
        }
    }
}
