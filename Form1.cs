using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox2.Text, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            fs.Close();
            MessageBox.Show("Content is written in file successfully");
        }








        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox2.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            textBox3.Text = sr.ReadToEnd();
            fs.Close();

        }




        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox2.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String str = sr.ReadToEnd();
            int i = (str.IndexOf(textBox4.Text, 0));
            if (i > -1)
            {
                MessageBox.Show("This word is exist in the file");
            }
            else
            {
                MessageBox.Show("This word is not exist in the file try another words");
            }
        }





        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox2.Text, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox5.Text);
            sw.Close();
            fs.Close();

            MessageBox.Show("The Text is appended suuccessfully");
        }




        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        

    





