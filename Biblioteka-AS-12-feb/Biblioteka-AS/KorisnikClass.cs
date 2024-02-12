using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_AS
{
    public class KorisnikClass
    {
        public string ime, prezime, god, brtel, email, oib, adresa;
        #region value
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string God { get => god; set => god = value; }
        public string Brtel { get => brtel; set => brtel = value; }
        public string Email { get => email; set => email = value; }
        public string Oib { get => oib; set => oib = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        #endregion

        public KorisnikClass(string ime, string prezime, string god, string brtel, string email, string oib, string adresa)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.God = god;
            this.Brtel = brtel;
            this.Email = email;
            this.Oib = oib;
            this.Adresa = adresa;
        }

        public override string ToString()
        {
            string ispis = null;

            ispis = this.Ime + "\t" + this.Prezime + "\t" + this.God + "\t" + this.Brtel + "\t" + this.Email + "\t" + this.Oib + "\t" + this.Adresa;
            return ispis;
        }
    }
}
