using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW1
{
    public partial class Form9 : Form
    {
        DateStor dateStor = new DateStor();
        double volumeGas=0, payGas = 0, litrGasPrace, payAdd=0;
       public Form9()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            volumeGasTextBox10.Enabled = true;
            summGastextBox11.Enabled = false;
            PriceAddIsert();
        }
         private void PriceAddIsert()
        {
            priceAdd0textBox2.Text = dateStor.priceAdd[0].ToString();
            priceAdd1textBox3.Text = dateStor.priceAdd[1].ToString();
            priceAdd2textBox4.Text = dateStor.priceAdd[2].ToString();
            priceAdd3textBox5.Text = dateStor.priceAdd[3].ToString();
        }
        private void volumeGasTextBox10_TextChanged(object sender, EventArgs e)
        {
            volumeGas = Convert.ToDouble(volumeGasTextBox10.Text);
            payGas = volumeGas * litrGasPrace;
            summGastextBox11.Text = payGas.ToString();
            GasPricelabel1.Text = summGastextBox11.Text;
        }

        private void summGastextBox11_TextChanged(object sender, EventArgs e)
        {
            payGas = Convert.ToDouble(summGastextBox11.Text);
            volumeGas = payGas / litrGasPrace;
            volumeGasTextBox10.Text = volumeGas.ToString();
            GasPricelabel1.Text = summGastextBox11.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            volumeGasTextBox10.Enabled = true;
            summGastextBox11.Enabled = false;
        }

        private void Add0checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numberAdd0textBox9.Enabled = true;
            numberAdd0textBox9.Text = "1";
        }

        private void Add1checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numberAdd1textBox8.Enabled = true;
            numberAdd1textBox8.Text = "1";
        }

        private void Add2checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numberAdd2textBox7.Enabled = true;
            numberAdd2textBox7.Text = "1";
        }

        private void Add3checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numberAdd3textBox6.Enabled = true;
            numberAdd3textBox6.Text = "1";
        }

        private void numberAdd1textBox8_TextChanged(object sender, EventArgs e)
        {
            payAdd += Convert.ToDouble(numberAdd1textBox8.Text) * dateStor.priceAdd[1];
            AddPriselabel2.Text = payAdd.ToString();
        }

        private void numberAdd2textBox7_TextChanged(object sender, EventArgs e)
        {
            payAdd += Convert.ToDouble(numberAdd2textBox7.Text) * dateStor.priceAdd[2];
            AddPriselabel2.Text = payAdd.ToString();
        }

        private void numberAdd3textBox6_TextChanged(object sender, EventArgs e)
        {
            payAdd += Convert.ToDouble(numberAdd3textBox6.Text) * dateStor.priceAdd[3];
            AddPriselabel2.Text = payAdd.ToString();
        }
        private void total()
        {
            totalLabel10.Text = (payGas + payAdd).ToString();
        }
        private void GasPricelabel1_TextChanged(object sender, EventArgs e)
        {
            total();
        }

        private void AddPriselabel2_Click(object sender, EventArgs e)
        {
            total();
        }

        private void numberAdd0textBox9_TextChanged(object sender, EventArgs e)
        {
            payAdd += Convert.ToDouble(numberAdd0textBox9.Text) * dateStor.priceAdd[0];
            AddPriselabel2.Text = payAdd.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            volumeGasTextBox10.Enabled = false;
            summGastextBox11.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    litrGasPrace = dateStor.priceGas[0];
                    break;
                case 1:
                    litrGasPrace = dateStor.priceGas[1];
                    break;
                case 2:
                    litrGasPrace = dateStor.priceGas[2];
                    break;
                default:
                    break;
            }
            priceGasText.Text = litrGasPrace.ToString();

        }
    }
}
