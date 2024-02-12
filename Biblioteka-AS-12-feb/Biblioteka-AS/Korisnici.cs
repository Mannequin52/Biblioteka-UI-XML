using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Biblioteka_AS
{
    public partial class Korisnici : Form
    {
        List<KorisnikClass> korisnikList = new List<KorisnikClass>();
        public Korisnici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Korisnici_Load(object sender, EventArgs e)
        {
            ispisKorisnicitxt.Text = "Ime:" + "\nPrezime:" + "\nGod:" + "\nBroj tel.:" + "\nEmail:" + "\nOIB:" + "\nAdresa:";

            foreach (KorisnikClass upiskorisnik in korisnikList)
            {
                ispisKorisnicitxt.AppendText("\n\n" + upiskorisnik.ToString());
            }
        }

        

        private void spremikorisnikbtn_Click(object sender, EventArgs e)
        {
            var dokumentXmlKorisnik = new XDocument();
            var rootElem = new XElement("Korisnici");
            dokumentXmlKorisnik.Add(rootElem);
            foreach (KorisnikClass korisnik in korisnikList)
            {

                var korisnikElem = new XElement("Korisnik",
                    new XAttribute("Ime", korisnik.ime),
                    new XAttribute("Prezime", korisnik.prezime),
                    new XAttribute("Godina-rod", korisnik.god),
                    new XElement("Broj-tel", korisnik.brtel),
                    new XElement("E-mail", korisnik.email),
                    new XElement("OIB", korisnik.oib),
                    new XElement("Adresa", korisnik.adresa));
                rootElem.Add(korisnikElem);

            }
            foreach (KorisnikClass korisnik in korisnikList)
            {
                xmlispis.AppendText(dokumentXmlKorisnik.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == "Ime")
            {
                var res = from s in korisnikList
                          orderby s.Ime descending
                          select s;
                xmlispis = (RichTextBox)res;
            }
            if (comboBox1.SelectedValue == "Prezime") 
            {
                var res = from s in korisnikList
                          orderby s.Prezime descending
                          select s;
                xmlispis = (RichTextBox)res;
            }
            this.Update();
        }
    }
}
