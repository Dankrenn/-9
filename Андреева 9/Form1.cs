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
   
    public partial class Form1 : Form
    {
        Form2 form;
        public Form1( )
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        options a = new options(0, 0, 0,0,0);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double width = Convert.ToDouble(textBox1.Text);
                double height = Convert.ToDouble(textBox2.Text);
                double thickness = Convert.ToDouble(textBox3.Text);                
                a.width = width;
                a.thickness = thickness;
                a.height= height;
                double s = 0;
                double v = 0;
                a.s = a.Square(a,s);
                if(a.s == 0 )
                {
                    MessageBox.Show("Убедитесь в правильности ввода данных");
                    return;
                }
                textBox4.Text = Convert.ToString(a.s);
                a.v = a.Volume(a, v);
                if (a.v == 0)
                {
                    MessageBox.Show("Убедитесь в правильности ввода данных");
                    return;
                }
                textBox5.Text = Convert.ToString(a.v);
            }
            catch(Exception)
            {
                MessageBox.Show("Убедитесь в правильности ввода данных");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                this.Hide();

                new Form2(this, a).Show();
            }
            //else 
            //{
            //    MessageBox.Show("Вы ввели не все данные");
            //}

        }
    }
    public class options
    {
        public double width;
        public double height;
        public double thickness;
        public double v;
        public double s;
        public options()
        {

        }
        public options(double width, double height, double thickness, double v, double s)
        {
            this.v = v;
            this.s = s;
            this.width = width;
            this.height = height;
            this.thickness = thickness;
        }

        public double Volume(options a, double v)
        {
            width = a.width;
            height = a.height;
            thickness = a.thickness;
           
            if(width * height * thickness > 0)
            {
                return (v = width * height * thickness);
            }
            else 
                return v = 0;
        }
        public double Square(options a, double s)
        {
            width = a.width;
            height = a.height;       
            if (width * height > 0)
               return (s = width * height);
            else
               return s = 0;
        }
    }

    public class calculation : options
    {
        public calculation()
        { 

        }
        string name;
        string tupe;
        double price;
        double weight;
        double density ;
        double total ;
        public calculation(double width, double height, double thickness, double v, double s, string name, string tupe, double price, double weight, double density, double total) : base(width,height,thickness,v,s)
        {
            
            this.name = name;
            this.tupe = tupe;
            this.price = price;
            this.weight = weight;
            this.density = density;
            this.total = total;


        }
        public double Densitys (double weight, double v, double density)
        {
            return (density = (weight / v));
        }
        public double Total(double price, double weight, double total)
        {
            return (total = (price / weight));
        }
    }
}
