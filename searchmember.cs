using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management
{
    public partial class searchmember : Form
    {
        public searchmember()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
             
                cmd.CommandText = "Select" newmember where mid = "+txtsearch.text+";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("لطفا شناسه ایدی را وارد کنید." , "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select newmember";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
