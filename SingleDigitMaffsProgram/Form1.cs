using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleDigitMaffsProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //NEVER SPEAK OF AGAIN
        private void btnKlick_Click(object sender, EventArgs e)
        {
            string tal = (textBox1.Text);
            int test = int.Parse(tal);

            int mellanTal1 = 0;
            int mellanTal2 = 0;
            int mellanTal3 = 0;

            if (test <= 0)
            {
                char tal1 = tal[0];
                string stringtal1 = tal1.ToString();
                mellanTal1 = int.Parse(stringtal1);
            }
           
            if (test <= 10)
            {
                char tal2 = tal[1];
                string stringtal2 = tal2.ToString();
                mellanTal2 = int.Parse(stringtal2);
            }
            
            if (test <=100)
            {
                char tal3 = tal[2];
                string stringtal3 = tal3.ToString();
                mellanTal3 = int.Parse(stringtal3);
            }
            
            int talResultat1 = mellanTal1 + mellanTal2 + mellanTal3;
            
            string stringTalResultat1 = talResultat1.ToString();
            char charTal1 = stringTalResultat1[0];
            string stringCharTalResult1 = charTal1.ToString();
            int sentTal1 = int.Parse(stringCharTalResult1);
            char charTal2 = stringTalResultat1[1];
            string stringCharTalResult2 = charTal2.ToString();
            int sentTal2 = int.Parse(stringCharTalResult2);

            int talResultat = sentTal1 + sentTal2;

            string answer = talResultat.ToString();
            lblAnswer.Text = talResultat.ToString();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
