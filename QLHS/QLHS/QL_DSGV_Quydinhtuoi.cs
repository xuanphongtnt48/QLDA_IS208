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
    public partial class QL_DSGV_Quydinhtuoi : Form
    {
        DataQLHSDataContext qlhs;
        public QL_DSGV_Quydinhtuoi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void QL_DSGV_Quydinhtuoi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Update_TUOIGV(float.Parse(txtMin.Text), float.Parse(txtMax.Text));
        }
    }
}
