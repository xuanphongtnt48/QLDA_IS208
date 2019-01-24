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
    public partial class QL_DSHS_Quydinhtuoi : Form
    {
        DataQLHSDataContext qlhs;
        public QL_DSHS_Quydinhtuoi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Update_TUOIHS(float.Parse(txtMin.Text),float.Parse(txtMax.Text));
        }

        private void QL_DSHS_Quydinhtuoi_Load(object sender, EventArgs e)
        {
        }
    }
}
