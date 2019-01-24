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
    public partial class QL_PC : Form
    {
        DataQLHSDataContext qlhs;
        public QL_PC()
        {
            InitializeComponent();
        }

        private void QL_PC_Load(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            cbChonKhoi.DisplayMember = "MaKhoi";
            cbChonKhoi.DataSource = qlhs.KHOIs;
            cbChonLop.DisplayMember = "MaLop";
            cbChonLop.DataSource = qlhs.LOPs;
            cbChonHK.DisplayMember = "MaHocKy";
            cbChonHK.DataSource = qlhs.HOCKies;
            cbChonMon.DisplayMember = "MaMon";
            cbChonMon.DataSource = qlhs.MONHOCs;
            cbChonGiaoVien.DisplayMember = "MaGiaoVien";
            cbChonGiaoVien.DataSource = qlhs.GIAOVIENs;
            //dtgPC.DataSource = qlhs.select_GIANGDAY(cbChonKhoi.Text, cbChonLop.Text, cbChonHK.Text, cbChonMon.Text, cbChonGiaoVien.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            dtgPC.DataSource = qlhs.select_GIANGDAY(cbChonKhoi.Text, cbChonLop.Text, cbChonHK.Text,
                int.Parse(txNamHoc.Text));
            cbChonGiaoVien.DataBindings.Clear();
            cbChonGiaoVien.DataBindings.Add("text",dtgPC.DataSource,"MaGiaoVien");
            cbChonMon.DataBindings.Clear();
            cbChonMon.DataBindings.Add("text", dtgPC.DataSource, "MaMon");
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            try
            {
                qlhs.Insert_GIANGDAY(cbChonLop.Text, cbChonHK.Text,
                int.Parse(txNamHoc.Text), cbChonMon.Text, cbChonGiaoVien.Text);
                qlhs.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("giao vien đã dc phân công không thể phân công");
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            try
            {
               qlhs.UPDATE_GIANGDAY(cbChonLop.Text, cbChonHK.Text,
                int.Parse(txNamHoc.Text), cbChonMon.Text, cbChonGiaoVien.Text);
                qlhs.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("không thể sửa");
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Delete_GIANGDAY(cbChonGiaoVien.Text);
            qlhs.SubmitChanges();
        }
    }
}
