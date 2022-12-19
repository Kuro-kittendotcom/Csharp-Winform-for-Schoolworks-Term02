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


namespace โปรแกรมเงินเดือน
{
    public partial class Form1 : Form
    {
        double money = 0, tax = 0, income = 0; //ประกาศตัวแปร และค่าเริ่มต้นของมัน

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            //ซ่อน label จากหน้าฟอร์ม
        }

        private void button3_Click(object sender, EventArgs e) //ปุ่มออก
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void clear() //เมธอด clear ใช้สำหรับการรีเซ็ทหรือล้าง
        {
            label2.Text = "";
            label3.Text = "";
            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear(); //เรียกใช้เมธอด clear
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = double.TryParse(textBox1.Text, out money);
            //ประกาศตัวแปร boolean check ใช้เก็บค่าตรรกศาสตร์จาก double.TryParse
            //โดยจะเก็บค่าเป็น true ก็ต่อเมื่อมันสามารถแปลงค่าจาก textBox1 ซึ่งเป็นข้อมูลประเภท string ไปเป็น double 
            //และส่งค่าที่แปลงได้ไปที่ money
            //และจะเก็บค่า false ก็ต่อเมื่อไม่สามารถแปลงค่าจาก textBox1 ซึ่งเป็นข้อมูลประเภท string ไปเป็น double ได้

            if (check == true) //ถ้าตัวแปร check มีค่าเป็น true
            {
                if (radioButton1.Checked == true)
                {
                    tax = money * 0.03;
                }
                if (radioButton2.Checked == true)
                {
                    tax = money * 0.05;
                }
                if (radioButton3.Checked == true)
                {
                    tax = money * 0.07;
                }

                income = money - tax;
                label2.Text = "มูลค่าภาษี : " + tax.ToString("0.##");
                label3.Text = "รายรับสุทธิ : " + income.ToString("0.##");
            }
            else //ถ้าเงื่อนไขไม่เข้าข่าย if (check == true)
            {
                if (textBox1.Text != "") //ถ้า textBox1 =/= กล่องข้อความว่าง ๆ
                {
                    MessageBox.Show("กรุณาใส่เฉพาะตัวเลข", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //ถ้าเงื่อนไขไม่เข้าข่าย if (textBox1.Text != "")
                {
                    MessageBox.Show("กรุณาใส่ตัวเลขในช่อง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clear(); //เรียกใช้เมธอด clear
            }
        }
    }
}
