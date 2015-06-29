using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace XML_Aufgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("kunde_neu.xml");
            XmlNodeList list = xmldoc.GetElementsByTagName("tKunde");
            Decimal umsatz = 0;
            String zeile = default(String);
            foreach(XmlNode node in list)
            {

                XmlNodeList list2 = node.ChildNodes;
                zeile = "";
                foreach (XmlNode n2 in list2)
                {
                    if (n2.Name == "KundenId")
                    {
                        zeile = n2.InnerText + ": ";
                    }
                    if (n2.Name == "Name")
                    {
                        zeile += n2.InnerText + " - ";
                    }
                    if (n2.Name == "Umsatz")
                    {
                        zeile += n2.InnerText + "\n";
                        umsatz += Convert.ToDecimal(n2.InnerText);
                    }
                    
                }
                richTextBoxAuswertung.Text += zeile;
            }
            richTextBoxAuswertung.Text += "======= \n" + umsatz.ToString("C") + "\n\n";

                
        }
    }
}
