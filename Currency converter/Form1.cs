using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form1 : Form
    {
        private readonly double kursVD = 68932;
        private readonly double kursEuro = 4.3;
        private readonly double kursUsd = 3.91;
        private readonly double kursPlnDOEuro = 0.22;
        private readonly double kursPlnDOUsd = 0.24;
        private readonly double kursPlnDOVD = 0.000013;
        private readonly double kursEuroDoUsd = 1.08;
        private readonly double kursEuroDoVD = 0.000016;
        private readonly double kursUsdDoEuro = 0.89;
        private readonly double kursUsdDoVD = 0.000015;
        private readonly double kursVDDoUsd = 17630;
        private readonly double kursVDDoEuro = 16031;


        public Form1()
        {
            InitializeComponent();
            label_wź.Text = "Waluta żrodłowa ";
            label_wd.Text = "Waluta docelowa ";
        }

        private void radioButton_eur_CheckedChanged(object sender, EventArgs e)
        {
            label_wź.Text = "EUR";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrzeliczWalute();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();

        }

        private void radioButton_pln_CheckedChanged(object sender, EventArgs e)
        {

            label_wź.Text = "PLN";

        }

        private void PrzeliczWalute()
        {

            double wartoscWalutyZrodlowej;
            if (double.TryParse(textBox1.Text, out wartoscWalutyZrodlowej))
            {
                double kursWalutyDocelowej = 0.0;

                if (radioButton_pln.Checked)
                {
                    if (label_wd.Text == "EUR")
                    {
                        kursWalutyDocelowej = kursPlnDOEuro;
                    }
                    else if (label_wd.Text == "USD")
                    {
                        kursWalutyDocelowej = kursPlnDOUsd;
                    }
                    else if (label_wd.Text == "VD")
                    {
                        kursWalutyDocelowej = kursPlnDOVD;
                    }
                    else if (label_wd.Text == "PLN")
                    {
                        kursWalutyDocelowej = 1;
                    }

                }
                if (radioButton_eur.Checked)
                {
                    if (label_wd.Text == "EUR")
                    {
                        kursWalutyDocelowej = 1;
                    }
                    else if (label_wd.Text == "USD")
                    {
                        kursWalutyDocelowej = kursEuroDoUsd;
                    }
                    else if (label_wd.Text == "VD")
                    {
                        kursWalutyDocelowej = kursEuroDoVD;
                    }
                    else if (label_wd.Text == "PLN")
                    {
                        kursWalutyDocelowej = kursEuro;
                    }

                }
                if (radioButton_usd.Checked)
                {
                    if (label_wd.Text == "EUR")
                    {
                        kursWalutyDocelowej = kursUsdDoEuro;
                    }
                    else if (label_wd.Text == "USD")
                    {
                        kursWalutyDocelowej = 1;
                    }
                    else if (label_wd.Text == "VD")
                    {
                        kursWalutyDocelowej = kursUsdDoVD;
                    }
                    else if (label_wd.Text == "PLN")
                    {
                        kursWalutyDocelowej = kursUsd;
                    }

                }
                if (radioButton_vd.Checked)
                {
                    if (label_wd.Text == "EUR")
                    {
                        kursWalutyDocelowej = kursVDDoEuro;
                    }
                    else if (label_wd.Text == "USD")
                    {
                        kursWalutyDocelowej = kursVDDoUsd;
                    }
                    else if (label_wd.Text == "VD")
                    {
                        kursWalutyDocelowej = 1;
                    }
                    else if (label_wd.Text == "PLN")
                    {
                        kursWalutyDocelowej = kursVD;
                    }

                }
                double przeliczonaWartosc = wartoscWalutyZrodlowej * kursWalutyDocelowej;
                textBox2.Text = przeliczonaWartosc.ToString();


            }

        }


        private void radioButton_usd_CheckedChanged(object sender, EventArgs e)
        {
            label_wź.Text = "USD";
        }

        private void radioButton_vd_CheckedChanged(object sender, EventArgs e)
        {
            label_wź.Text = "VD";
        }

        private void radioButton_eur2_CheckedChanged(object sender, EventArgs e)
        {
            label_wd.Text = "EUR";
        }

        private void radioButton_pln2_CheckedChanged(object sender, EventArgs e)
        {
            label_wd.Text = "PLN";
        }

        private void radioButton_usd2_CheckedChanged(object sender, EventArgs e)
        {
            label_wd.Text = "USD";
        }

        private void radioButton_vd2_CheckedChanged(object sender, EventArgs e)
        {
            label_wd.Text = "VD";
        }
        
    }
}

    
          

          

        
        

        

       