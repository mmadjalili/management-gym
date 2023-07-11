using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (txtBoxuserName.Text == "admin" && txtBoxpassword.Text== "admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("!!نام کاربری یا رمز عبور نادرسته","eroror",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
