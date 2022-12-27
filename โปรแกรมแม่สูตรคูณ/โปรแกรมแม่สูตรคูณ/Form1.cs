using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


///// Read ME PLS! /////////////////////////////////////////////////////////////////////////
///// โปรแกรมนี้จะมีการใช้เงื่อนไข while...loop ซึ่งใช้ในการรันคำสั่งเดิมซํ้า ๆ และยังมีความอันตรายด้วย  /////
///// ใช้กันก็ระวัง ๆ ด้วยนะ ไม่งั้นคงมีโปรแกรมรันคำสั่งเดิมซํ้า ๆ จนไม่สิ้นสุดแน่ (ฮ่า)                  /////
///////////////////////////////////////////////////////////////////////////////////////////
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
            //ซ่อน label จากหน้าฟอร์ม
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        double x = 0, y = 0;
        string z = "";
        //ประกาศตัวแปรประเภท double กับ string และประกาศค่าเริ่มต้นให้ตัวแปร
        
            bool ez = double.TryParse(textBox1.Text, out y);
            //ประกาศตัวแปร boolean ez ใช้เก็บค่าตรรกศาสตร์จาก double.TryParse
            //โดยจะเก็บค่าเป็น true ก็ต่อเมื่อมันสามารถแปลงค่าจาก textBox1 ซึ่งเป็นข้อมูลประเภท string ไปเป็น double 
            //และส่งค่าที่แปลงได้ไปที่ y
            //และจะเก็บค่า false ก็ต่อเมื่อไม่สามารถแปลงค่าจาก textBox1 ซึ่งเป็นข้อมูลประเภท string ไปเป็น double ได้

            if (ez == true) //ถ้า ez มีค่าเป็น true
            {
                while (x < 13) //การใช้งานจะคล้าย if แต่จะใช้สำหรับการลูปคำสั่งซํ้า ๆ
                    //เมื่อตัวแปร x มีค่าน้อยกว่า 13
                {
                    z += y + " คูณด้วย " + x + " เท่ากับ " + (x * y).ToString("0.####") + "\n"; //คำสั่งสำหรับการคำนวณค่าและแสดงผลใน label
                    x++; //ให้ตัวแปร x มีค่า +1
                } //เมื่อสิ้นสุดกระบวนการภายในปีกกว่ามันจะรันคำสั่งซํ้า ๆ ไปจะกว่าตัวแปร x จะมีค่าไม่น้อยกว่า 13
                //ถ้าตัวแปร x มีค่าไม่น้อยกว่า 13 ก็จะไม่เข้าเงื่อนไข while (x < 13) ถือเป็นการสิ้นสุดกระบวนการของมัน

                label2.Text = z;
            }
            else //ถ้า ez มีค่าที่ไม่ใช่ true หรือก็คือ false
            {
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มรึเซ็ท
        {
            label2.Text = "";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e) //ปุ่มออก
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
