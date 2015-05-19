using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Jason1
{
    public partial class Form1 : Form
    {
        List<Kontakt> liKontakt = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJSONSerialize_Click(object sender, EventArgs e)
        {
            String result = JsonConvert.SerializeObject(liKontakt);
            richTextBox1.Text = result;
            StreamWriter sw = new StreamWriter("kontakte.json");
            JsonSerializer js = new JsonSerializer();
            JsonWriter jwr = new JsonTextWriter(sw);
            js.Serialize(jwr, liKontakt);
            jwr.Close();
            sw.Close();

        }

        private void buttonFillListe_Click(object sender, EventArgs e)
        {
            liKontakt.Add(new Kontakt { Firma = "bsz", Nachname = "Mauser", Vorname = "Doris", Telefonnummer = "0931 42444" });
            liKontakt.Add(new Kontakt { Firma = "bsz", Nachname = "Dr Wohlfahrt", Vorname = "Ernst", Telefonnummer = "0931 4222" });
            liKontakt.Add(new Kontakt { Firma = "bsz", Nachname = "Glatt", Vorname = "Petra", Telefonnummer = "0931 31333" });


        }

        private void buttonDesJson_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("kontakte.json");
            JsonSerializer js = new JsonSerializer();
            List<Kontakt> lst = (List<Kontakt>)js.Deserialize(sr, typeof(List<Kontakt>));
            dataGridView1.DataSource = lst;
        }
    }
}
