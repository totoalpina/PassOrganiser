
using System.Diagnostics;

using Newtonsoft.Json.Linq;
using PassOrganiser.connection;
using PassOrganiser.Entities;

namespace PassOrganiser.Forms
{
    public partial class DosareJson : Form
    {

        public Form RefToAdauga { get; set; }  
    
        public DosareJson()
        {
            InitializeComponent();
        }
        dbConnectionZenic conn = new ();

        private void btn_lista_dosare_json_Click( object sender, EventArgs e )
        {
            
            var result = conn.SelectAll();
            if (result != null)
            {
                rtx_dosare_json.Clear();
                rtx_dosare_json.Text = result;
            }


            try
            {
                File.WriteAllText("C:\\Users\\cosmi\\Desktop\\DosareJson.txt",
                    result);
                // https://stackoverflow.com/questions/10174156/open-file-with-associated-application
                new Process
                {
                    StartInfo = new ProcessStartInfo("C:\\Users\\cosmi\\Desktop\\DosareJson.txt")
                    {
                        UseShellExecute = true
                    }
                }.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ceva nu a mers");
            }
        }

        private void DosareJson_FormClosed( object sender, FormClosedEventArgs e )
        {
            RefToAdauga.Show();
        }

        private void btn_json_to_dosare_Click( object sender, EventArgs e )
        {
            List<Dosare> dosareConvertite = new();
            try
            {
                var jsonFile = File.ReadAllText("C:\\Users\\cosmi\\Desktop\\DosareJson.txt");

                 JArray dosareArray = JArray.Parse(jsonFile);

                dosareConvertite = dosareArray.Select(p => new Dosare
                (
                        p[ "id_dosar" ].ToString(),
                        p[ "id_creditor" ].ToString(),
                        p[ "id_debitor" ].ToString(),
                        p[ "nr_dosar" ].ToString(),
                        p[ "creditor"].ToString(),
                        p[ "adresa_creditor" ].ToString(),
                        p[ "debitor" ].ToString(),
                        p[ "cnp_debitor" ].ToString(),
                        p[ "adresa_debitor" ].ToString(),
                        p[ "titlu_executoriu" ].ToString()
                )).ToList();
                rtx_dosare_json.Clear();
                foreach (var dosar in dosareConvertite)
                {
                    rtx_dosare_json.Text += System.Environment.NewLine + "--------------------------------------------------------" 
                        + System.Environment.NewLine + System.Environment.NewLine + dosar.ToString();
                }
                File.WriteAllText("C:\\Users\\cosmi\\Desktop\\Resultat.txt", rtx_dosare_json.Text);
                new Process
                {
                    StartInfo = new ProcessStartInfo("C:\\Users\\cosmi\\Desktop\\Resultat.txt")
                    {
                        UseShellExecute = true
                    }
                }.Start();

            }
            catch (Exception ex )
            {
                MessageBox.Show("ceva nu a mers");
            }
        }
    }
}
