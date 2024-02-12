using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteka_AS
{
    public partial class Posudi : Form
    {
        public Posudi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void traziKnjiga_Click(object sender, EventArgs e)
        {
            string ime = traziImeKnjiga.Text;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
