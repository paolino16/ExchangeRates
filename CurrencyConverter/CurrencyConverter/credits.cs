using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Credits : MetroFramework.Forms.MetroForm //use the metroform skin
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void credits_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ryan-morrison-18114066");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ryan.pm");
        }
    }
}
