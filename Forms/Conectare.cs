using System.Windows.Input;
using PassOrganiser.connection;

namespace PassOrganiser
{
    public partial class frm_main : Form
    {
        
        public frm_main()
        {
            InitializeComponent();
            pnl_mesaj_inchidere.Visible = false;
        }

        private void afiseazaFormAdauga()
        {
            AdaugInformatii adaugInformatii = new AdaugInformatii();
            adaugInformatii.RefToConectare = this;
            this.Visible = false;
            pnl_mesaj_inchidere.Dock = DockStyle.Fill;
            pnl_mesaj_inchidere.Visible = true;
            adaugInformatii.Show();
        }

        private void btn_intra_Click( object sender, EventArgs e )
        {
            dbConnection conn = new();
            if ( (txt_UserName.Text.Trim().ToLower() != "" && txt_Password.Text != "" &&
                !txt_Password.Text.Contains("'") && !txt_Password.Text.Contains(";")) || txt_fastline.Text != "" )
            {
                if ( (conn.verifyLoginFields(txt_UserName.Text.Trim().ToLower(), txt_Password.Text.Trim().ToLower()) || conn.verifyLoginFastLine(txt_fastline.Text)))
                {
                    afiseazaFormAdauga();
                }
                else
                {
                    MessageBox.Show("Parola sau utilizatorul gresite. Incercati din nou");
                }
            }
            else
            {
                MessageBox.Show("Campurile sunt goale sau contin caractere interzise: \"'\" sau \";\".Introduceti utilizator si parola");
            }
        }

        private void txt_UserName_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == 6 )
            {
                dbConnection conn = new dbConnection();
                if ( txt_UserName.Text.Trim().ToLower() != "" && txt_Password.Text != "" )
                {
                    if ( conn.verifyLoginFields(txt_UserName.Text.Trim().ToLower(), txt_Password.Text.Trim().ToLower()) )
                    {
                        afiseazaFormAdauga();
                    }
                    else
                    {
                        MessageBox.Show("Parola sau utilizatorul gresite. Incercati din nou");
                    }
                }
                else
                {
                    MessageBox.Show("Campurile nu pot fi goale. Introduceti utilizator si parola");
                }
            }
            
            
        }

        private void txt_fastline_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == ( char ) Keys.Return )
            {
                dbConnection conn = new dbConnection();

                if (  txt_fastline.Text != "" )
                {
                    if ( conn.verifyLoginFastLine(txt_fastline.Text))
                    {
                        afiseazaFormAdauga();
                    }
                    else
                    {
                        MessageBox.Show("Parola sau utilizatorul gresite. Incercati din nou");
                    }
                }
                else
                {
                    MessageBox.Show("Campurile nu pot fi goale. Introduceti utilizator si parola");
                }
            }
            
        }
    }
}