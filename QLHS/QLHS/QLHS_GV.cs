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
    public partial class QLHS_GV : Form
    {
        public QLHS_GV()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Dangnhap qlhs_dn = new QLHS_Dangnhap();
            qlhs_dn.Show();
            Visible = false;
        }

        private void QLHS_GV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Doimatkhau qlhs_dmk = new QLHS_Doimatkhau();
            qlhs_dmk.Show();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Capnhatthongtin qlhs_cntt = new QLHS_Capnhatthongtin();
            qlhs_cntt.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_GV_ND qlhs_gv_nd = new QLHS_GV_ND();
            qlhs_gv_nd.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_TC_DSL ql_tc_dsl = new QL_TC_DSL();
            ql_tc_dsl.Show();
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_TC_BD ql_tc_bd = new QL_TC_BD();
            ql_tc_bd.Show();
        }

        private void tổngKếtMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_BC_TKM ql_bc_tkm = new QL_BC_TKM();
            ql_bc_tkm.Show();
        }

        private void tổngKếtHọcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_BC_TKHK ql_bc_tkhk = new QL_BC_TKHK();
            ql_bc_tkhk.Show();
        }
    }
}
