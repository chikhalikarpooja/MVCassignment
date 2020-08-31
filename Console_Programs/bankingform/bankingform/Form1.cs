using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banklibrary;
namespace bankingform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account act = null;
      
            
        private void button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string acttype = textBox3.Text;
            if (acttype == "saving")
            {
                act = new Saving();

            }
            else if (acttype == "current")
            {
                act = new Current();

            }
            else
            {
                MessageBox.Show("please enter saving or current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if(act != null)
            {
                act.AccountNo = actno;
                string res = act.Deposit(amount);
                label3.Text = res;
                
            }
        }
    }
}
