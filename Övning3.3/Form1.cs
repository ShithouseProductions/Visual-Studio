using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(tbxA.Text);
            int talB = int.Parse(tbxB.Text);
            int talC = int.Parse(tbxC.Text);

            int summa = talA + talB + talC;
            string summaText = summa.ToString();
            lblSumma.Text = summaText;

            float medel = summa / 3f;
            string medelText = medel.ToString();
            lblMedel.Text = medelText;

        }
    }
}
