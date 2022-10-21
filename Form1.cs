using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmak_2
{
    public partial class Hesap_Makinası : Form
    {
        string operat = "";
        double sayim = 0;
        bool degi1 = true;
        public Hesap_Makinası()
        {
            InitializeComponent();
        }
        private void butonlarim(object sender, EventArgs e)
        {
            if (degi1 == false)
            {
                textBox1.Clear();
            }
            degi1 = true;

                textBox1.Text += (sender as Button).Text;
             
        }
        private void opera(object sender, EventArgs e)
        {
            degi1 = true;
            string neval = (sender as Button).Text;
            metot();
            operat = neval;
            label1.Text = " " + sayim.ToString() + " " + operat + " ";
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text == "" || textBox1.Text == null || textBox1.Text == string.Empty)
            {
                if (degi1)
                {
                    label1.Text +=   textBox1.Text + label1.Text.Remove(3)+ " =";
                    degi1 = false;
                }
            }
            else
            {
                if (degi1)
                {
                    label1.Text +=  " "+ textBox1.Text + "  "+" = ";
                    degi1 = false;
                }
            }
            textBox1.Text = metot().ToString();
            operat = "";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
            textBox1.Clear();
            sayim = 0;
            operat = "";
            label1.Text = "";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
                btn_0.Enabled = true;
            }
            degi1 = true;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox1.Text != string.Empty||textBox1.Text!=null)
            {
                if ((textBox1.Text).Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    this.BackColor = Color.CadetBlue;
                }               
            }
        }
        private void key(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0: btn_0.PerformClick(); break;
                case Keys.NumPad1: btn_1.PerformClick(); break;
                case Keys.NumPad2: btn_2.PerformClick(); break;
                case Keys.NumPad3: btn_3.PerformClick(); break;
                case Keys.NumPad4: btn_4.PerformClick(); break;
                case Keys.NumPad5: btn_5.PerformClick(); break;
                case Keys.NumPad6: btn_6.PerformClick(); break;
                case Keys.NumPad7: btn_7.PerformClick(); break;
                case Keys.NumPad8: btn_8.PerformClick(); break;
                case Keys.NumPad9: btn_9.PerformClick(); break;
                case Keys.ShiftKey: btn_esittir.PerformClick();break;
                case Keys.Add: btn_arti.PerformClick(); break;
                case Keys.Divide: btn_bolu.PerformClick();break;
                case Keys.Multiply: btn_carpı.PerformClick(); break;
                case Keys.Delete: btn_clear.PerformClick(); break;
                case Keys.Back: btn_gerial.PerformClick(); break;
                case Keys.Decimal: btn_virgul.PerformClick(); break;
                case Keys.Subtract: btn_eksi.PerformClick(); break;
                default:
                    break;
            }
        }
        public double metot()
        {
            if (textBox1.Text == "" || textBox1.Text == null || textBox1.Text == string.Empty)
            {
                switch (operat)
                {
                    case "+": sayim += sayim; break;
                    case "-": sayim -= sayim; break;
                    case "x": sayim *= sayim; break;
                    case "/": sayim /= sayim; break;
                    default: sayim = sayim; break;
                }
            }
            else
            {
                switch (operat)
                {
                    case "+": sayim += double.Parse(textBox1.Text); break;
                    case "-": sayim -= double.Parse(textBox1.Text); break;
                    case "x": sayim *= double.Parse(textBox1.Text); break;
                    case "/": sayim /= double.Parse(textBox1.Text); break;
                    default: sayim = double.Parse(textBox1.Text); break;
                }
            }
            return sayim;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            degi1 = true;
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }

        }
    }
}