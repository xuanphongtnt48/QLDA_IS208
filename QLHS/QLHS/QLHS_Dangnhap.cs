using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM
{
    public partial class QLHS_Dangnhap : Form
    {
        bool check;
        public QLHS_Dangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPass.Text == "admin")
            {
                
                QLHS qlhs = new QLHS();
                qlhs.Show();
                Visible = false;
            }
            else
                if (txtUsername.Text == "giaovien" && txtPass.Text == "giaovien")
            {
                QLHS_GV qlhs_gv = new QLHS_GV();
                qlhs_gv.Show();
                Visible = false;
            }
            else
                if(txtUsername.Text=="hocsinh" && txtPass.Text == "hocsinh")
            {
                QLHS_HS qlhs_hs = new QLHS_HS();
                qlhs_hs.Show();
                Visible = false;
            }
            else
                MessageBox.Show("Login failed", "Error");
        }

        private void QLHS_Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
