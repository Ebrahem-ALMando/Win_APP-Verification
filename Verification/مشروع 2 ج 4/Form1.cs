using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_2_ج_4
{
    public partial class Form1 : Form
    {
        string h = "ebrahem", p = "20012001";
        int i = 1;
        Form2 fr= new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 3)
                if (textBox1.Text == h && textBox2.Text == p)
                    fr.Show();
                    else if(textBox1.Text==""&& textBox2.Text=="")
                        MessageBox.Show("املأ المعلومات");
                else
                {
                    i++;
                    MessageBox.Show("المعلومات خاطئة", "تسجيل دخوول");
                }
            else
            { Close(); }
            
        }
    }
}
