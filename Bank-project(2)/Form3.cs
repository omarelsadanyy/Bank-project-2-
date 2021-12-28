using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank_project_2_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorProvider1.SetError(textBox1, " Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
            }
            if (String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider2.SetError(textBox2, " Password is required");
                return;
            }
            else
            {
                errorProvider3.SetError(textBox2, string.Empty);
            }
            if (String.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                errorProvider3.SetError(textBox3, " phone is required");
                return;
            }
            else
            {
                errorProvider3.SetError(textBox4, string.Empty);
            }
            if (String.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                errorProvider4.SetError(textBox4, " Address is required");
                return;
            }
            else
            {
                errorProvider4.SetError(textBox4, string.Empty);
            }
            if (String.IsNullOrEmpty(textBox5.Text.ToString (). Trim()))
            {
                errorProvider5.SetError(textBox5, " Balance is required");
                return;
            }
            else
            {
                errorProvider5.SetError(textBox5, string.Empty);
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please check that you choose the type of account" , "Error" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            string name = textBox1.Text;
            string address = textBox4.Text;
            string phone = textBox3.Text;
            Client c = new Client(name, address, phone);
            double balance = double.Parse(textBox5.Text);
            Bankaccount account = null;
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                account = new Bankaccount(balance);
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                account = new SavingsBankaccount(balance);
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You can only choose one type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (!checkBox1.Checked && !checkBox2.Checked)
            //{
            //    MessageBox.Show("Please check that you choose the type of account");
            //}
            account.Owner = c;
            c.Account = account;
            List.accounts.Add(account);
            List.allclients.Add(c);
            MessageBox.Show("account created successfully"+ Environment.NewLine + " your id is "+account.accountid);
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Hide();
            //Form2 frm2 = new Form2();
            //frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;
            //if (!char.IsDigit (ch) && ch!=8)
            //{
            //    e.Handled = true;
            //}
        }
    }
}
