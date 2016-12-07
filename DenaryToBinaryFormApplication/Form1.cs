using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenaryToBinaryFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDenaryToBinary_Click(object sender, EventArgs e)
        {
            int[] placeValues = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int[] binaryNumber = new int[8];
            textBinary.Text = "";
            int denaryNumber = Convert.ToInt32(textDenary.Text);

            for (int i = 0; i < placeValues.Length; i++)
            {
                if (denaryNumber >= placeValues[i])
                {
                    binaryNumber[i] = 1;
                    denaryNumber = denaryNumber - placeValues[i];
                }

                else
                {
                    binaryNumber[i] = 0;
                }
            }

            foreach (int i in binaryNumber)
            {
               textBinary.AppendText(i + "    ");
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
