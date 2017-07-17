using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahtekimlikprojesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = textBox1.Text;
            form2.label2.Text = textBox2.Text;
            form2.label3.Text = textBox3.Text;
            form2.label4.Text = textBox4.Text;
            form2.label5.Text = textBox5.Text;
            form2.label6.Text = textBox6.Text;
            form2.label7.Text = textBox7.Text;
            form2.pictureBox1.ImageLocation = textBox8.Text;

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //

            openFileDialog1.Title = "Resim Seçiniz";

            openFileDialog1.Filter = "Text files (*.jpg)|*.jpg|Tüm dosyalar (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)



            {






                textBox8.Text = openFileDialog1.FileName;

                //burda picturebox1.load(Textbox1.Text); Yazarakta resim yolunu almış olurduk..

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.label1.Text = textBox1.Text;
            form3.label2.Text = textBox2.Text;
            form3.label3.Text = textBox3.Text;
            form3.label4.Text = textBox4.Text;
            form3.label5.Text = textBox5.Text;
            form3.label6.Text = textBox6.Text;
            form3.label7.Text = textBox7.Text;
            form3.pictureBox1.ImageLocation = textBox8.Text;

            form3.Show();
        }
    }
}