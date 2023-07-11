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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gym_management
{
    public partial class deletemember : Form
    {
        public deletemember()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("حذف شود؟؟", "delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from newmember where mid =" + textBox1 + ";
                  SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select" newmember ";
             SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void deletemember_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select newmember" ;
           SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}