using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


///// Read ME PLS! ////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////// Credit : Kuro_kitten ///////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////


namespace โปรแกรมแม่สูตรคูณ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        public void clear()
        {
            label2.Text = "";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string output = "";
            int userInput = 0;

            bool check = int.TryParse(textBox1.Text, out userInput);

            if (check)
            {
                if (userInput > 25)
                {
                    MessageBox.Show("โปรแกรมนี้รองรับเลขสูงสุดที่ 25 เท่านั้น", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
                else if (userInput < 1)
                {
                    MessageBox.Show("โปรแกรมนี้รองรับเลขตํ่าสุดที่ 1 เท่านั้น", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
                else
                {
                    for (int i = 1; i < 13; i++)
                    {
                        output += userInput + " x " + i + " = " + (userInput * i).ToString() + "\n";
                    }

                    label2.Text = output;
                }
            }
            else 
            {
                clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
