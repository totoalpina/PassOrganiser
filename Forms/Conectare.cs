using System.Windows.Input;
using PassOrganiser.connection;

namespace PassOrganiser
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }


        private void btn_intra_Click(object sender, EventArgs e)
        {
            dbConnection conn = new dbConnection();
            if (txt_UserName.Text.Trim().ToLower() != "" && txt_Password.Text != "") { 
                if (conn.verifyLogin(txt_UserName.Text.Trim().ToLower(), txt_Password.Text.Trim().ToLower()) 
                     )
                {
                    AdaugInformatii adaugInformatii = new AdaugInformatii();
                    adaugInformatii.RefToConectare = this;
                    this.Visible = false;
                    adaugInformatii.Show();
                }
                else
                {
                    MessageBox.Show("Parola sau utilizatorul gresite. Incercati din nou");
                }
            } else
            {
                MessageBox.Show("Campurile nu pot fi goale. Introduceti utilizator si parola");
            }

            this.Visible = false;

        }

        private void txt_UserName_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                dbConnection conn = new dbConnection ();
                if ( txt_UserName.Text.Trim ().ToLower () != "" && txt_Password.Text != "" )
                {
                    if ( conn.verifyLogin (txt_UserName.Text.Trim ().ToLower (), txt_Password.Text.Trim ().ToLower ())
                       )
                    {
                        AdaugInformatii adaugInformatii = new AdaugInformatii ();
                        adaugInformatii.RefToConectare = this;
                        this.Visible = false;
                        adaugInformatii.Show ();
                    }
                    else
                    {
                        MessageBox.Show ("Parola sau utilizatorul gresite. Incercati din nou");
                    }
                }
                else
                {
                    MessageBox.Show ("Campurile nu pot fi goale. Introduceti utilizator si parola");
                }
            }
        }
    }
}