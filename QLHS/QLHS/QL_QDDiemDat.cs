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
    public partial class QL_QDDiemDat : Form
    {
        DataQLHSDataContext qlhs;
        public QL_QDDiemDat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Update_DiemDat(float.Parse(textBox1.Text), float.Parse(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
