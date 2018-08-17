using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// Jairo Frias Ureña 15-EISN-1-237 sec. 0908
//
namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();            
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 3);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 4);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 5);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 7);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 9);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 11);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 13);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            int Total = 0;
            label1.Text = "Total";
            label2.Text = "Numero de dados";


            while (Number > 0)
            {
                int D2 = Dice.Next(1, 21);
                Total = Total + D2;
                listBox1.Items.Add(Convert.ToString(D2));
                textBox1.Text = (Convert.ToString(Total));
                Number = Number - 1;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox2.Text == "" || textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }

            int Number = Convert.ToInt16(textBox2.Text);
            Random Dice = new Random();
            label1.Text = "Ultimo valor %";
            label2.Text = "Numero de intentos";

            while (Number > 0)
            {
                int D2 = Dice.Next(1, 101);                
                listBox1.Items.Add(Convert.ToString(D2)+ "%");
                textBox1.Text = (Convert.ToString(D2))+ "%";
                Number = Number - 1;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
