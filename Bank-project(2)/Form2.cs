using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank_project_2_
{
    public partial class Form2 : Form
    {
        static int checkforaccount(int accountid)
        {
            Bankaccount account = getaccountbyid(accountid);
            if (account == null)
            {
                //MessageBox.Show("account not found");
                return 0 ;
            }
            else
            {
                //MessageBox.Show("account exsit");
                return 1 ;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //int ID =int.Parse (textBox1.Text);
           //string password = textBox2.Text;
            if (String.IsNullOrEmpty(textBox1.Text.ToString().Trim()))
            {
                errorProvider1.SetError(textBox1, "ID is required");
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
                errorProvider2.SetError(textBox2, string.Empty);
            }
            int ID = int.Parse(textBox1.Text);
            string password = textBox2.Text;
            int x = checkforaccount(ID);
            if (x==0)
            {
                MessageBox.Show("account not found" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if (x==1)
            {
              //  MessageBox.Show("account exsit");
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            //this.Hide();
            //int ID = int.Parse(textBox1.Text);
            //int password = int.Parse(textBox2.Text);
            //Form5 frm5 = new Form5();
            //frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3 ();
            frm3.Show();
        }
    }
}
