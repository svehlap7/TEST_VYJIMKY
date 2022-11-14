using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYJIMKY_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double cislo = 0;
            double soucet = 0;
            double pocet = 0;
            double prumer;
            try
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    try
                    {
                        cislo = Convert.ToInt32(textBox1.Lines[i]);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("CHYBA ZAPSANI NA RADKU!");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("MOC VELKE NEBO MALE CISLO!");
                    }
                    if (cislo < 0)
                    {
                        pocet++;
                        {
                            soucet += cislo;
                        }
                    }
                }
                if (pocet > 0)
                {
                    prumer = soucet / pocet;
                    MessageBox.Show("PRUMER JE: " + prumer);
                }
                else 
                {
                    MessageBox.Show("NEJSOU ZDE ZAPORNA CISLA!");
                } 
            }
            catch (OverflowException)
            {
                MessageBox.Show("PRETECENO!");
            }
            catch (FormatException)
            {
                MessageBox.Show("V TEXTBOXU NIC NENI!");
            }
        }
    }
}
