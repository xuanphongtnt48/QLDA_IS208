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
    public partial class QLHS : Form
    {
        public QLHS()
        {
            InitializeComponent();
        }

        private void QLHS_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DSGV ql_dsgv = new QL_DSGV();
            ql_dsgv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DSHS ql_dshs = new QL_DSHS();
            ql_dshs.Show();
        }

        private void điểmĐạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_QDDiemDat ql_qddd = new QL_QDDiemDat();
            ql_qddd.Show();
        }

        private void mônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MonHoc ql_mh = new QL_MonHoc();
            ql_mh.Show();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Lop ql_l = new QL_Lop();
            ql_l.Show();
        }

        private void QLHS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Dangnhap qlhs_dn = new QLHS_Dangnhap();
            qlhs_dn.Show();
            Visible = false;
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Capnhatthongtin qlhs_cntt = new QLHS_Capnhatthongtin();
            qlhs_cntt.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHS_Doimatkhau qlhs_dmk = new QLHS_Doimatkhau();
            qlhs_dmk.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_PC ql_pc = new QL_PC();
            ql_pc.Show();
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
