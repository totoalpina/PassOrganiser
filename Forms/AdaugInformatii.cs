using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
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
        public List<Cont> list;

        public AdaugInformatii()
        {
            InitializeComponent();
        }

        dbConnection conn = new dbConnection();
        private void AdaugInformatii_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

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
            List<Cont> searchedList = new List<Cont>();
            foreach (var cont in list)
            {
                if (cont.concatAllProperties.Contains(txt_cauta.Text.ToLower()))
                {
                    searchedList.Add (cont);
                }
            }

            dgrd_cautare.DataSource = searchedList;
        }

        private void dgrd_cautare_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            Editare editare = new Editare();
            editare.id = long.Parse (dgrd_cautare.Rows [ dgrd_cautare.CurrentRow.Index ].Cells [ 0 ].Value.ToString ());
            editare.editCont = conn.selectCont(editare.id);
            editare.RefToAdaugare = this;
            this.Visible = false;
            editare.ShowDialog();
        }

        private void AdaugInformatii_Load ( object sender, EventArgs e )
        {
            list = conn.SelectAll();
            dgrd_cautare.DataSource = list;

            dgrd_cautare.Columns [ "id" ].Visible = false;
            dgrd_cautare.Columns [ "concatAllProperties" ].Visible = false;
            dgrd_cautare.Columns["categorie"].HeaderText = "Categorie";
            dgrd_cautare.Columns["userName"].HeaderText = "User Name";
            dgrd_cautare.Columns["password"].HeaderText = "Password";
            dgrd_cautare.Columns["description"].HeaderText = "Description";
        }

        private void btn_refresh_Click ( object sender, EventArgs e )
        {
            list.Clear();
            list = conn.SelectAll ();
            dgrd_cautare.DataSource = list;
        }

        private void txt_categorie_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                txt_username.Focus ();
            }
        }

        private void txt_username_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                txt_parola.Focus ();
            }
        }

        private void txt_parola_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                rTxt_descriere.Focus ();
            }
        }

        private void rTxt_descriere_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                Cont c = new Cont (txt_categorie.Text, txt_username.Text,
                    txt_parola.Text, rTxt_descriere.Text);
                string query = "INSERT INTO conturi (id, categorie, username, password, description) " +
                               "VALUES (" + c.id + ", '" + c.categorie + "' , '" + c.userName + "' , '"
                               + c.password + "' , '" + c.description + "' );";

                conn.Insert (query);
                txt_categorie.Clear ();
                txt_username.Clear ();
                txt_parola.Clear ();
                rTxt_descriere.Clear ();
                MessageBox.Show ("Inregistrare resuita");
            }
        }
        
        private void AdaugInformatii_Shown ( object sender, EventArgs e )
        {
            pnl_cautare.Location = new Point (3, 3);
            pnl_adaugare.Visible = false;
            txt_categorie.Focus ();
        }

        private void txt_cauta_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                List<Cont> searchedList = new List<Cont> ();
                foreach ( var cont in list )
                {
                    if ( cont.concatAllProperties.Contains (txt_cauta.Text.ToLower ()) )
                    {
                        searchedList.Add (cont);
                    }
                }

                dgrd_cautare.DataSource = searchedList;
            }
        }

        private void btn_open_adauga_pnl_Click ( object sender, EventArgs e )
        {
            pnl_adaugare.Location = new Point(3, 3);
            pnl_cautare.Visible = false;
            pnl_adaugare.Visible = true;
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            pnl_adaugare.Visible = false;
            pnl_cautare.Visible = true;
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            long deleteId = 0;
            if ( dgrd_cautare.CurrentRow == null)
            {
                MessageBox.Show ("Please select a record to delete!");
            }
            else
            {
                deleteId = long.Parse (dgrd_cautare.Rows [ dgrd_cautare.CurrentRow.Index ].Cells [ 0 ].Value.ToString ());
            }
            
            string query = $"DELETE FROM conturi WHERE id = {deleteId}";
            ;
            if ( deleteId != 0 && MessageBox.Show ("Doriti sa stergeti informatia?", "Confirmare stergere!", MessageBoxButtons.YesNo)  == DialogResult.Yes )
            {
                conn.Delete(query);
                list.Clear ();
                list = conn.SelectAll ();
                dgrd_cautare.DataSource = list;
            }
            
            
        }
    }
}
