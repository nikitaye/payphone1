using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payphone
{
    public partial class Wallet : Form
    {
       
        public Wallet()
        {
            
            InitializeComponent();
           button1.FlatAppearance.BorderSize = 0;
           button1.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;


            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;

        }
        public int summ;

        public event EventHandler<string> MyEvent;
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                if (summ > 500)
                    summ = 500;
                if (MyEvent != null) MyEvent(this, summ.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        #region money      
        private void button1_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 1;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
          
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 200;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 100;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 50;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 20;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 10;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 5;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 2;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (summ < 500)
            {
                summ = summ + 500;
                textBox1.Text = "Ви хочете покласти " + summ.ToString();
            }
            else
            {
                textBox1.Text = "Ви внесли максимальну сумму " + summ.ToString();
            }
        }
        #endregion

    }
}
