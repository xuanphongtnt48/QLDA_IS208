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
    public partial class QL_BC_TKM : Form
    {
        public QL_BC_TKM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tONGKETBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tONGKETBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlsv1DataSet);

        }

        private void QL_BC_TKM_Load(object sender, EventArgs e)
        {
            
            DataQLHSDataContext bcm = new DataQLHSDataContext();
            var Lst = (from s in bcm.TONGKETs select s);
            dtgv_BCM.DataSource = Lst;
            cbb_Mon.DataSource = bcm.MONHOCs;
            cbb_Mon.DisplayMember = "TenMon";
            cbb_Mon.ValueMember = "MaMon";
            cbb_HK.DataSource = bcm.HOCKies;
            cbb_HK.DisplayMember = "TenHocKy";
            cbb_HK.ValueMember = "MaHocKy";
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            DataQLHSDataContext bcm = new DataQLHSDataContext();
            this.tONGKETTableAdapter.Fill(this.qlsv1DataSet.TONGKET);
            var Lst = (from s in bcm.TONGKETs
                       where s.MaHocKy.Contains((cbb_Mon.SelectedValue).ToString()) && (s.MaLop.Contains(cbb_HK.SelectedValue.ToString()))
                       select s);
        }
    }
}
