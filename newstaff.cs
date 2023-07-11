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
    public partial class newstaff : Form
    {
        public newstaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtfname.Text;
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
            string state = txtstate.Text;
            string city = txtcity.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into newstaff (fname,lname,gender,dob,mobile,email,joindate,statee,city) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + state + "','" + city + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("اطلاعات ذخیره شد.");

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtmobile.Clear();
            txtcity.Clear();
            txtemail.Clear();
            txtstate.Clear();
            dateTimePickerdob.Value = DateTime.Now;
            dateTimePickerjoindate.Value = DateTime.Now;
        }

     
        
    }
}
