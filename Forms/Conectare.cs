using System.Text.RegularExpressions;
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
            pnl_main.Visible = false;
            adaugInformatii.Show();
        }

        private void btn_intra_Click( object sender, EventArgs e )
        {

            dbConnection conn = new();
            if ( ( txt_UserName.Text.Trim().ToLower() != "" && txt_Password.Text != "" &&
                !txt_Password.Text.Contains("'") && !txt_Password.Text.Contains(";") ) || txt_fastline.Text != "" )
            {
                if ( conn.VerifyLoginFields(txt_UserName.Text.Trim().ToLower(), txt_Password.Text.Trim()) || conn.VerifyLoginFastLine(txt_fastline.Text) )
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
                    if ( conn.VerifyLoginFields(txt_UserName.Text.Trim().ToLower(), txt_Password.Text.Trim().ToLower()) )
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

                if ( txt_fastline.Text != "" )
                {
                    if ( conn.VerifyLoginFastLine(txt_fastline.Text) )
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

        private void txt_fastline_KeyDown( object sender, System.Windows.Forms.KeyEventArgs e )
        {
            /*var split = Regex.Matches(txt_fastline.Text, @"(^(.*)(?=\s))|(?<=\s)(.*)");

            if ( split.Count > 1 )
            {
                txt_UserName.Text = split[ 0 ].ToString();
                txt_Password.Text = split[ 1 ].ToString();
            }
            else
            {
                txt_UserName.Clear();
                txt_Password.Clear();
            }*/

            // MessageBox.Show("acum");
        }

        private void txt_fastline_TextChanged( object sender, EventArgs e )
        {
            var split = Regex.Matches(txt_fastline.Text, @"(^(.*)(?=\s))|(?<=\s)(.*)");

            if ( split.Count > 1 )
            {
                txt_UserName.Text = split[ 0 ].ToString();
                txt_Password.Text = split[ 1 ].ToString();
            }
            else
            {
                txt_UserName.Clear();
                txt_Password.Clear();
            }
        }
    }
}