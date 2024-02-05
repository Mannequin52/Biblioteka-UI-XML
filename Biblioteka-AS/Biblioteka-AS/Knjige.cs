using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Biblioteka_AS
{
    public partial class Knjige : Form
    {
        List<KnjigaClass> knjigaList = new List<KnjigaClass>();
        public Knjige()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void osvjezibtn_Click(object sender, EventArgs e)
        {
            
        }
        private void ispisKnjigetxt_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            ispisKnjigetxt.Text = "Autor:" + "\n" + "Naziv:" + "\n"+ "ISBN:" + "\n" + "Izdavac:" + "\n" + "Godina izdanja:" + "\n\n";

            foreach (KnjigaClass upisknjige in knjigaList)
            {
                ispisKnjigetxt.AppendText("\n" + upisknjige.ToString());
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            var dokumentXmlKnjiga = new XDocument();
            var rootElem = new XElement("Knjige");
            dokumentXmlKnjiga.Add(rootElem);
            foreach (KnjigaClass knjiga in knjigaList)
            {

                var korisnikElem = new XElement("Knjiga",
                    new XAttribute("Ime", knjiga.ime),
                    new XAttribute("Naziv", knjiga.naziv),
                    new XAttribute("ISBN", knjiga.isbn),
                    new XElement("Izdavac", knjiga.izdavac),
                    new XElement("Godina", knjiga.godina));
                rootElem.Add(korisnikElem);

            }
            foreach (KnjigaClass knjiga in knjigaList)
            {
                xmlispis.AppendText(dokumentXmlKnjiga.ToString());
            }

           string ListToXML(List<KnjigaClass> lToSerialize)
            {
                using (var strWritr = new StringWriter(new StringBuilder()))
                {
                    var serializer = new XmlSerializer(typeof(List<KnjigaClass>));
                    serializer.Serialize(strWritr, lToSerialize);
                    return strWritr.ToString();
                }
            }
            List<KnjigaClass> XMLToList(string xml)
            {
                using (var strRdr = new StringReader(xml))
                {
                    var deSerializer = new XmlSerializer(typeof(List<string[]>));
                    var output = deSerializer.Deserialize(strRdr);
                    return output as List<KnjigaClass>;
                }
            }
            string xmlFromObject = ListToXML.knjigaListToXML(knjigaList);
            List<KnjigaClass> objectFromXml = XMLToList(xmlFromObject);
        }
    }
 }
    

