using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteka_AS
{
    public class KnjigaClass
    {
        public string ime, naziv, isbn, izdavac, godina;
        public int posudeno, skladiste;

        public KnjigaClass(string ime, string naziv, string isbn, string izdavac, string godina, int posudeno, int skladiste)
        {
            this.Ime = ime;
            this.Naziv = naziv;
            this.Isbn = isbn;
            this.Izdavac = izdavac;
            this.Godina = godina;
            this.Posudeno = posudeno;
            this.Skladiste = skladiste;
        }
        public KnjigaClass() { }
        #region value
        public string Ime { get => ime; set => ime = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public int Posudeno { get => posudeno; set => posudeno = value; }
        public int Skladiste { get => skladiste; set => skladiste = value; }
        public string Godina { get => godina; set => godina = value; }
        #endregion

        public override string ToString()
        {
            string ispis;

            ispis = this.Ime + "\t" + this.Naziv + "\t" +this.Izdavac + "\t" + this.Godina + "\t" + this.Isbn;

            return ispis;
        }

        
    }
    
}
