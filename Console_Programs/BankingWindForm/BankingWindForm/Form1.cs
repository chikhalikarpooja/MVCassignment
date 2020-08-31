using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_library;
namespace BankingWindForm
{
    public partial class Form1 : Form
    {
        
        

        Account a = new Account();
        

        
        int actno, amt;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            

            actno = Convert.ToInt32(textBox1.Text);
             amt = Convert.ToInt32(textBox2.Text);
            string actype = textBox3.Text;
            if(actype=="Saving")
            {
                a = new Saving();
            }
            else if(actype=="Current")
            {
                a = new Current();
            }
            else
            {
                MessageBox.Show("Please Enter Saving or Current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if(a!= null)
            {
                a.Acc_No = actno;
                string res=a.deposit(amt);
                MessageBox.Show(res);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = null;
            actno = Convert.ToInt32(textBox1.Text);
            amt = Convert.ToInt32(textBox2.Text);
            string actype = textBox3.Text;
            if (actype == "Saving")
            {
                a = new Saving();
            }
            else if (actype == "Current")
            {
                a = new Current();
            }
            else
            {
                MessageBox.Show("Please Enter Saving or Current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if (a != null)
            {
                a = new Withdraw();
                a.Acc_No = actno;
                string res = a.deposit(amt);
                MessageBox.Show(res);
            }
        }
    }
    }

