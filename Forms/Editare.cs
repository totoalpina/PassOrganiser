using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassOrganiser.connection;
using PassOrganiser.Entities;

namespace PassOrganiser.Forms
{
    public partial class Editare : Form
    {
        public long id { get; set; }
        public Cont editCont { get; set; }
        public Form RefToAdaugare { get; set; }

        public Editare()
        {
            InitializeComponent();

        }

        private void Editare_Load( object sender, EventArgs e )
        {

            txt_edit_categorie.Text = editCont.categorie;
            txt_edit_username.Text = editCont.userName;
            txt_edit_password.Text = editCont.password;
            rtext_edit_description.Text = editCont.description;

        }

        private void txt_edit_save_Click( object sender, EventArgs e )
        {
            dbConnection conn = new();
            string query =
                $"UPDATE conturi " +
                "SET " +
                    $"categorie = '{txt_edit_categorie.Text}', " +
                    $"username = '{txt_edit_username.Text}', " +
                    $"password = '{txt_edit_password.Text}', " +
                    $"description = '{rtext_edit_description.Text}' " +
                "WHERE " +
                    $"id = {id}; ";
            conn.Update(query);

        }

        private void Editare_FormClosed( object sender, FormClosedEventArgs e )
        {
            RefToAdaugare.Show();
        }
    }
}
