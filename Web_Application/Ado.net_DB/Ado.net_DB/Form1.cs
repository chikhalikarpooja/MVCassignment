using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ado.net_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("data source=DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database=StudentDatabase");
        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                int sid = Convert.ToInt32(textBox1.Text);
                string sn = textBox2.Text;
                string sadd = textBox3.Text;
                string qr = "select * from student_db where stud_id=" + sid + "";
                SqlCommand command = new SqlCommand(qr, cn);
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {
                    flag = 1;
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                }
                if (flag == 0)
                    label4.Text = "no record exist ";


            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                cn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                int sid = Convert.ToInt32(textBox1.Text);
                string sn = textBox2.Text;
                string sadd = textBox3.Text;
                string qr = "insert into student_db values(" + sid + ",'" + sn + "','" + sadd + "')";
                SqlCommand command = new SqlCommand(qr, cn);
                command.ExecuteNonQuery();
                label4.Text = "record saved ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                cn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                int sid = Convert.ToInt32(textBox1.Text);
                string sn = textBox2.Text;
                string sadd = textBox3.Text;
                string qr = "Update student_db set stud_name='" + sn + " ',stud_address ='" + sadd + "'where stud_id =" + sid +" ";
                SqlCommand command = new SqlCommand(qr, cn);
                command.ExecuteNonQuery();
                label4.Text = "record updated ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                int sid = Convert.ToInt32(textBox1.Text);
                string sn = textBox2.Text;
                string sadd = textBox3.Text;
                string qr = "delete from student_db where stud_id= "+ sid + " ";
                SqlCommand command = new SqlCommand(qr, cn);
                command.ExecuteNonQuery();
                label4.Text = "record deleted ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
