using DevExpress.XtraBars.Docking;
using MySql.Data.MySqlClient;
using PassOrganiser.Entities;

namespace PassOrganiser.connection
{
    public class dbConnection
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public dbConnection ( )
        {
            Initialize ();
        }

        //Initialize values
        private void Initialize ( )
        {
            server = "localhost";
            database = "password_organiser";
            uid = "root";
            password = "783326";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection (connectionString);
        }

        //open connection to database
        private bool OpenConnection ( )
        {
            try
            {
                connection.Open ();
                return true;
            }
            catch ( MySqlException ex )
            {
                switch ( ex.Number )
                {
                    case 0:
                        MessageBox.Show ("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show ("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection ( )
        {
            try
            {
                connection.Close ();
                return true;
            }
            catch ( MySqlException ex )
            {
                MessageBox.Show (ex.Message);
                return false;
            }
        }

        public void Insert ( string query )
        {
            if ( this.OpenConnection () == true )
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand (query, connection);

                //Execute command
                cmd.ExecuteNonQuery ();

                //close connection
                this.CloseConnection ();
            }
        }
        // Select cont by ID 
        public Cont selectCont ( long id )
        {
            string query = "SELECT * FROM conturi WHERE id = " + id + ";";
            Cont editCont = new Cont ();
            if ( this.OpenConnection () == true )
            {
                MySqlCommand cmd = new MySqlCommand (query, connection);
                MySqlDataReader dr = cmd.ExecuteReader ();
                while ( dr.Read () )
                {
                    editCont.id = long.Parse (dr [ "id" ].ToString ());
                    editCont.userName = dr [ "username" ].ToString ();
                    editCont.password = dr [ "password" ].ToString ();
                    editCont.categorie = dr [ "categorie" ].ToString ();
                    editCont.description = dr [ "description" ].ToString ();
                }
                this.CloseConnection ();
            }

            return editCont;
        }

        //Update statement
        public void Update ( string query )
        {
            if ( this.OpenConnection () == true )
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand ();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                string message = cmd.ExecuteNonQuery () > 0 ? "Inregistrare editata cu succes" : "Editare esuata";
                MessageBox.Show (message);
                //close connection
                this.CloseConnection ();
            }
        }

        //Delete statement
        public void Delete ( string query )
        {
            if ( this.OpenConnection () == true )
            {
                MySqlCommand cmd = new MySqlCommand (query, connection);
                cmd.ExecuteNonQuery ();
                this.CloseConnection ();
            }
        }

        public List<Cont> SelectAll ( )
        {
            List<Cont> allitems = new List<Cont> ();
            if ( this.OpenConnection () == true )
            {
                string query = "SELECT * FROM conturi;";

                MySqlCommand cmd = new MySqlCommand (query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader ();

                while ( dataReader.Read () )
                {
                    allitems.Add (new Cont (long.Parse (dataReader [ "id" ].ToString ()), dataReader [ "categorie" ].ToString (), dataReader [ "username" ].ToString (), dataReader [ "password" ].ToString (), dataReader [ "description" ].ToString ()));

                }
                dataReader.Close ();
                this.CloseConnection ();
                return allitems;
            }
            return allitems;
        }

        public List<Cont> Search ( string query )
        {
            List<Cont> searchList = new List<Cont> ();
            if ( this.OpenConnection () == true )
            {


                MySqlCommand cmd = new MySqlCommand (query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader ();

                while ( dataReader.Read () )
                {
                    searchList.Add (new Cont (
                                        long.Parse (dataReader [ "id" ].ToString ()),
                                        dataReader [ "categorie" ].ToString (), 
                                        dataReader [ "username" ].ToString (), 
                                        dataReader [ "password" ].ToString (), 
                                        dataReader [ "description" ].ToString ())
                                        );
                }
                dataReader.Close ();
                this.CloseConnection ();
                return searchList;
            }
            return searchList;
        }

        public bool verifyLogin ( string username, string pass )
        {
            MySqlDataReader dataReader;
            string query = $"SELECT * FROM users WHERE " +
                           $" username = '{username}' " +
                           $" AND password = '{pass}';";
            try
            {
                connection.Open ();
                MySqlCommand cmd = new MySqlCommand (query, connection);
                dataReader = cmd.ExecuteReader ();
                if ( dataReader.HasRows )
                {
                    return true;
                }
                else
                {
                    MessageBox.Show ("Stai jos 4 !");
                    return false;
                }

            }
            catch ( MySqlException ex )
            {
                MessageBox.Show ("Username sau password gresite. Please try again");
                return false;
            }
            dataReader.Close ();
            this.CloseConnection ();

        }
    }
}
