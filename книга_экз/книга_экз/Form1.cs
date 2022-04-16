using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace книга_экз
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Validating += textBox1_Validating;
            textBox2.Validating += textBox2_Validating;
            maskedTextBox1.Validating += maskedTextBox1_Validating;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string n = "\n\n";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox1.Text + n + textBox2.Text + n + maskedTextBox1.Text);
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Не указано имя!");
            }
            else if (textBox1.Text.Length < 20)
            {
                errorProvider1.SetError(textBox1, "Слишком короткое имя!");
            }
            else if (textBox1.Text.Length > 75)
            {
                errorProvider1.SetError(textBox1, "Слишком длинное имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Не указано название!");
            }
            else if (textBox2.Text.Length < 10)
            {
                errorProvider2.SetError(textBox2, "Слишком короткое название!");
            }
            else if (textBox2.Text.Length > 100)
            {
                errorProvider2.SetError(textBox2, "Слишком длинное название!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
          
            

            
      }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                errorProvider3.SetError(maskedTextBox1, "Не указано название!");
            }
            else if (maskedTextBox1.Text.Length < 4)
            {
                errorProvider3.SetError(maskedTextBox1, "Год должен состоять из 4 цифр!");
            }
            else if (maskedTextBox1.Text.Length > 4)
            {
                errorProvider3.SetError(maskedTextBox1, "Год должен состоять из 4 цифр!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
    }
}
