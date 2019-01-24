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
    public partial class QLHS_HS : Form
    {
        public QLHS_HS()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Dangnhap qlhs_dn = new QLHS_Dangnhap();
            qlhs_dn.Show();
            Visible = false;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Doimatkhau qlhs_dmk = new QLHS_Doimatkhau();
            qlhs_dmk.Show();
        }

        private void QLHS_HS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Capnhatthongtin qlhs_cntt = new QLHS_Capnhatthongtin();
            qlhs_cntt.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_TC_DSL ql_tc_dsl = new QL_TC_DSL();
            ql_tc_dsl.Show();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_HS_TC_BD qlhs_hs_tc_bd = new QLHS_HS_TC_BD();
            qlhs_hs_tc_bd.Show();
        }
    }
}
