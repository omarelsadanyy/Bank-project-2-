using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank_project_2_
{

    public partial class Form5 : Form
    {
        void withdraw()
        {
            int accountid = int.Parse(textBox4.Text);
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                //MessageBox.Show("account not found");
                return;
            }
            double amount = double.Parse(textBox3.Text);
            if (account.withdraw(amount))
            {
                MessageBox.Show("Successful transaction" ,"" , MessageBoxButtons.OK , MessageBoxIcon.Asterisk );
            }
        }
        void delete()
        {

            int accountid = int.Parse(textBox5.Text);
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                //MessageBox.Show("account not found");
                return;
            }
            List.accounts.Remove(account);
            List.allclients.Remove(account.Owner);
            MessageBox.Show("Account Deleted" , "" , MessageBoxButtons.OK , MessageBoxIcon.Asterisk );
        }
        void Deposite()
        {

            int accountid = int.Parse(textBox1.Text);
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                //MessageBox.Show("account not found");
                return;
            }

            double amount = double.Parse(textBox2.Text);
            if (account.diposite(amount))
            {
                MessageBox.Show("Successful transaction", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        static void checkforaccount(int accountid)
        {
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                MessageBox.Show("account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("account exsit" , "" ,MessageBoxButtons.OK , MessageBoxIcon.Asterisk );
            }
        }
        static Bankaccount getaccountbyid(int accountid)
        {
            for (int i = 0; i < List.accounts.Count; i++)
            {
                if (List.accounts[i].Accountid == accountid)
                {
                    return List.accounts[i];
                }
            }
            return null;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
            //Form2 frm2 = new Form2();
            //frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider2.SetError(textBox2, "Please check the amount entered");
                return;
            }
            else
            {
                errorProvider2.SetError(textBox2, string.Empty);
            }
            Deposite();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text.ToString().Trim()))
            {
                errorProvider4.SetError(textBox3, "Please check the amount entered");
                return;
            }
            else
            {
                errorProvider4.SetError(textBox3, string.Empty);
            }
            withdraw();
           // MessageBox.Show("Successful transaction");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            delete();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.ToString ().Trim()))
            {
                errorProvider1.SetError(textBox1, " ID is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
            }
            int accountid = int.Parse(textBox1.Text);
           
            checkforaccount(accountid);
            getaccountbyid(accountid);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text.ToString().Trim()))
            {
                errorProvider3.SetError(textBox4, " ID is required");
                return;
            }
            else
            {
                errorProvider3.SetError(textBox4, string.Empty);
            }
            int accountid = int.Parse(textBox4.Text);
            checkforaccount(accountid);
            getaccountbyid(accountid);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text.ToString().Trim()))
            {
                errorProvider5.SetError(textBox5, " ID is required");
                return;
            }
            else
            {
                errorProvider5.SetError(textBox5, string.Empty);
            }
            int accountid = int.Parse(textBox5.Text);
            checkforaccount(accountid);
            getaccountbyid(accountid);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox7.Text.ToString().Trim()))
            {
                errorProvider6.SetError(textBox7, " ID is required");
                return;
            }
            else
            {
                errorProvider6.SetError(textBox7, string.Empty);
            }
            int accountid = int.Parse(textBox7.Text);
            checkforaccount(accountid);
            Viewaccount();
           
        }

        private void Viewaccount()
        {
            int accountid = int.Parse(textBox7.Text);
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                //MessageBox.Show("account not found");
                return;
            }
            textBox6.Text = account.view();
            //account.view();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.BackColor = this.BackColor;
        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
