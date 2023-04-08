using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Андреева_9
{
    public partial class Form2 : Form
    {
        Form1 form;
        options a;
        public Form2(Form1 objec,options objecc)
        {
            form = objec;
            a = objecc;
            
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        uint density = 0;
        uint total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                options options = a;
                double price = Convert.ToDouble(textBox3.Text);
                double weight = Convert.ToDouble(textBox6.Text);
                string name = textBox1.Text;
                string tupe = textBox2.Text;
                double d = 0;
                double t = 0;
                calculation aa = new calculation(a.width, a.height, a.thickness, a.v,a.s, name, tupe, price, weight,d,t);  
                if(a.width <= 0&& a.v <= 0 && a.height <= 0 && a.thickness <= 0 && price <= 0 && weight <= 0)
                {
                    MessageBox.Show("Убедитесь в правильности ввода данных в двух формах");
                    return;
                }
                
                textBox4.Text = Convert.ToString(aa.Densitys(weight, aa.v, d));
                textBox5.Text = Convert.ToString(aa.Total(price ,weight , t));
            //}
           // catch (Exception ) 
            //{
            //    MessageBox.Show("неверный формат");
            //}
        }
    }
}
