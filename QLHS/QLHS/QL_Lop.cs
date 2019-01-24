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
    public partial class QL_Lop : Form
    {
        DataQLHSDataContext qlhs ;
        public QL_Lop()
        {
            InitializeComponent();
        }

        private void QL_Lop_Load(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            cbChonKhoi.DisplayMember = "MaKhoi";
            //cbChonKhoi.ValueMember = "";
            cbChonKhoi.DataSource = qlhs.KHOIs;
            dtgLop.DataSource = qlhs.select_AllLop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void box_ChonKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            //KHOI khoi = new KHOI();
            //khoi.MaKhoi = cbChonKhoi.Text;
           dtgLop.DataSource = qlhs.select_AllLopMA(cbChonKhoi.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
