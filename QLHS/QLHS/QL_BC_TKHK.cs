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
    public partial class QL_BC_TKHK : Form
    {
        public QL_BC_TKHK()
        {
            InitializeComponent();
        }
        

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            DataQLHSDataContext bchk = new DataQLHSDataContext();
            this.tONGKETTableAdapter.Fill(this.qlsv1DataSet.TONGKET);
            var Lst = (from s in bchk.TONGKETs
                       where s.MaHocKy.Contains((cbb_HK.SelectedValue).ToString())&&(s.MaLop.Contains(cbb_Lop.SelectedValue.ToString()))
                       select s);
        }

        private void cbb_MaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void QL_BC_TKHK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsv1DataSet.TONGKET' table. You can move, or remove it, as needed.
            this.tONGKETTableAdapter.Fill(this.qlsv1DataSet.TONGKET);
            DataQLHSDataContext bchk = new DataQLHSDataContext();
            var Lst = (from s in bchk.TONGKETs select s);
            dtgv_BCTK.DataSource = Lst;
            cbb_Lop.DataSource = bchk.LOPs;
            cbb_Lop.DisplayMember = "TenLop";
            cbb_Lop.ValueMember = "MaLop";
            cbb_HK.DataSource = bchk.HOCKies;
            cbb_HK.DisplayMember = "TenHocKy";
            cbb_HK.ValueMember = "MaHocKy";
        }
    }
}
