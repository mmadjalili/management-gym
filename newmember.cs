using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gym_management
{
    public partial class newmember : Form
    {
        public newmember()
        {
            InitializeComponent();
        }

        private void newmember_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fname = txtfirstname.Text;
            string lname = txtlastname.Text;
            string gender = "";
            bool ischaked = radioButton1.Checked;
            if (ischaked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string dob = dateTimePickerdob.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            string email = txtemail.Text;
            string joindate = dateTimePickerjoindate.Text;
            string gymtime = comboBoxgymtime.Text;
            string address = txtaddress.Text;
            string membership = comboBoxmembership.Text;

              SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into newmember (fname,lname,gender,dob,mobile,email,joindate,gymtime,maddress,membershiptime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + gymtime + "','" + address + "','" + membership + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("اطلاعات ذخیره شد.");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtfirstname.Clear();
            txtlastname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBoxgymtime.ResetText();
            comboBoxmembership.ResetText();
            txtaddress.Clear();

            dateTimePickerdob.Value = DateTime.Now;
            dateTimePickerjoindate.Value =DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
