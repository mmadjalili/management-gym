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

namespace gym_management
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            viewEquipment ve = new viewEquipment();
            ve.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string equipname = txtequipname.Text;
            string description = txtdescription.Text;
            string mused = txtmusclesused.Text;
            string ddate = dateTimePickerdeliverydate.Text;
            Int64 cost = Int64.Parse(txtcost.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SafirCo\\source\\repos\\gym management\\gym management\\Database1.mdf\";Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into equipment (equipname,edescription,mused,ddate,cost) values ('" + equipname + "','" + description + "','" + mused + "','" + ddate + "','" + cost + "')";
            //('" + equipname + "', " + cost + ")


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("اطلاعات ذخیره شد."  "inserted , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtequipname.Clear();
            txtdescription.Clear();
            txtmusclesused.Clear();
            txtcost.Clear();
            dateTimePickerdeliverydate.Value = DateTime.Now;
        }
    }
}
