using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning02_02
{
    public partial class Meddelande : Form
    {
        public Meddelande()
        {
            InitializeComponent();
        }
        //Metoden visar en meddelanderuta
        private void BtnMeddelande_Click(object sender, EventArgs e)
        {
            //Här visas meddelanderutan
            MessageBox.Show("Är det roligt att programmera?", "Övning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
