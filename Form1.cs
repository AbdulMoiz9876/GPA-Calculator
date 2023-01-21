using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] arr = new float[6];
            int[] arr1 = new int[6];
            float[] mul = new float[6];
            float suma = 0;
            int sum = 0;
            float gpa1 = 0;
            int a;
            string c;
            arr[0] = Int32.Parse(textbox1.Text);
            arr[1] = Int32.Parse(textbox2.Text);
            arr[2] = Int32.Parse(textbox3.Text);
            arr[3] = Int32.Parse(textbox4.Text);
            arr[4] = Int32.Parse(textbox5.Text);
            arr[5] = Int32.Parse(textbox6.Text);

            arr1[0] = Int32.Parse(combobox1.Text);
            arr1[1] = Int32.Parse(combobox2.Text);
            arr1[2] = Int32.Parse(combobox3.Text);
            arr1[3] = Int32.Parse(combobox4.Text);
            arr1[4] = Int32.Parse(combobox5.Text);
            arr1[5] = Int32.Parse(combobox6.Text);

            if (checkBox1.Checked)
            {
                arr[0] = 0;
            }
            if (checkBox2.Checked)
            {
                arr[1] = 0;
            }
            if (checkBox3.Checked)
            {
                arr[2] = 0;
            }
            if (checkBox4.Checked)
            {
                arr[3] = 0;
            }
            if (checkBox5.Checked)
            {
                arr[4] = 0;
            }
            if (checkBox6.Checked)
            {
                arr[5] = 0;
            }
            else
            {

            }

            for (int i = 0; i <= 5; i++)
            {
                mul[i] = arr[i] * arr1[i];
                suma += mul[i];
            }
            sum = arr1[0] + arr1[1] + arr1[2] + arr1[3] + arr1[4] + arr1[5];
            gpa1 = suma / sum;
            if (gpa1 >= 90 && gpa1 <= 100)
            {
                gpa.Text = "A+" + " 4.0";
            }
            else if (gpa1 < 90 && gpa1 >= 80)
            {
                gpa.Text = "A" + " 3.65";
            }
            else if (gpa1 < 80 && gpa1 >= 70)
            {
                gpa.Text = "B" + " 3.0";
            }
            else if (gpa1 < 70 && gpa1 >= 60)
            {
                gpa.Text = "C" + " 2.4";
            }
            else if (gpa1 < 60 && gpa1 >= 50)
            {
                gpa.Text = "D" + " 2.0";
            }
            else if (gpa1 < 50)
            {
                gpa.Text = "F" + " 1.0"; 
            }
            else
            {
                gpa.Text = "Error!";
            }

        }

        private void ds1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
