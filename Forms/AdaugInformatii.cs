using System.Data;
using System.Windows.Controls;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.Extensions;
using PassOrganiser.connection;
using PassOrganiser.Entities;
using PassOrganiser.Forms;

namespace PassOrganiser
{
    public partial class AdaugInformatii : Form
    {
        public Form RefToConectare { get; set; }
        public AdaugInformatii()
        {
            InitializeComponent();
        }
        dbConnection conn = new dbConnection();
        private void AdaugInformatii_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToConectare.Show();
        }

        private void btn_adauga_informatii_Click(object sender, EventArgs e)
        {
            Cont c = new Cont ( txt_categorie.Text, txt_username.Text, 
                              txt_parola.Text, rTxt_descriere.Text );
            string query = "INSERT INTO conturi (id, categorie, username, password, description) " +
                            "VALUES (" + c.id + ", '" + c.categorie + "' , '" + c.userName + "' , '"
                            + c.password + "' , '" + c.description + "' );";

            conn.Insert(query);
            txt_categorie.Clear();
            txt_username.Clear();
            txt_parola.Clear();
            rTxt_descriere.Clear();
            MessageBox.Show("Inregistrare resuita");
        }

        private void btn_cauta_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM conturi " +
                            "WHERE categorie LIKE '%" + txt_cauta.Text + "%' " +
                            "OR username LIKE '%" + txt_cauta.Text + "%' " +
                            "OR description LIKE '%" + txt_cauta.Text + "%' " +
                            "OR password LIKE '%" + txt_cauta.Text + "%';";

            List<Cont> searchedList = conn.Search(query);
            foreach (var VARIABLE in searchedList)
                MessageBox.Show(VARIABLE.id.ToString());
            {
                
            }
            dgrd_cautare.DataSource = searchedList;
        }

        private void dgrd_cautare_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            Editare editare = new Editare();
            editare.id = long.Parse (dgrd_cautare.Rows [ dgrd_cautare.CurrentRow.Index ].Cells [ 0 ].Value.ToString ());
            editare.editCont = conn.selectCont(editare.id);
            editare.ShowDialog();
        }

        private void AdaugInformatii_Load ( object sender, EventArgs e )
        {
            List<Cont> allItems = conn.SelectAll();
            dgrd_cautare.DataSource = allItems;
        }
    }
}
