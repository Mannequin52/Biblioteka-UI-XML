using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteka_AS
{
    public partial class Knjiga : Form
    {
        List<KnjigaClass> knjigaList = new List<KnjigaClass>();

        public Knjiga()
        {
            InitializeComponent();
        }

        private void Knjiga_Load(object sender, EventArgs e)
        {

        }

        private void autorimetxt_TextChanged(object sender, EventArgs e)
        {

        }


        public void unesiknjigubtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da ovo želite spremiti?", "Upozorenje", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Yes)
            {
                KnjigaClass upisknjiga = new KnjigaClass(autorimetxt.Text, nazivknjigetxt.Text, isbntxt.Text, izdavactxt.Text, Convert.ToString(godinatxt.Text));
                knjigaList.Add(upisknjiga);
            }
            this.Close();
        }

        private void odustaniknjigabtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnknjigaclr_Click(object sender, EventArgs e)
        {
            autorimetxt.Clear();
            nazivknjigetxt.Clear();
            isbntxt.Clear();
            izdavactxt.Clear();
            godinatxt.Clear();
        }

        private void nazivknjigetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
