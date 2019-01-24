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
    public partial class QL_DSGV : Form
    {
        DataQLHSDataContext qlhs;
        public QL_DSGV()
        {
            InitializeComponent();
        }

        private void textBox_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ThemHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            try
            {
                qlhs.Insert_GiaoVien(txtMS.Text, txtHoTen.Text, cbGioiTinh.Text, dateTimePicker_NgSinh.Value,
                    txtNoiSinh.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text,txtMaMon.Text);
                qlhs.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Giao Viên bạn muốn thêm đã có trong danh sách không thể thêm mới");
            }
        }

        private void QL_DSGV_Load(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            cbChonKhoi.DisplayMember = "TenMOn";
            cbChonKhoi.ValueMember = "MaMon";
            cbChonKhoi.DataSource = qlhs.MONHOCs;
            txtMon.DataBindings.Add("Text", cbChonKhoi.DataSource, "TenMon");
            txtMaMon.DataBindings.Add("Text", cbChonKhoi.DataSource, "MaMOn");
        }

        private void comboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            dtgGiaoVien.DataSource = qlhs.select_GiaoVien(txtMaMon.Text);
            for (int i = 0; i < dtgGiaoVien.Rows.Count; i++)
            {
                if (dtgGiaoVien.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgGiaoVien.Rows[i].Cells[0].Value = i + 1;
                }
            }
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dtgGiaoVien.DataSource, "TenGiaoVien");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("text", dtgGiaoVien.DataSource, "GioiTinh");
            dateTimePicker_NgSinh.DataBindings.Clear();
            dateTimePicker_NgSinh.DataBindings.Add("text", dtgGiaoVien.DataSource, "NgaySinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("text", dtgGiaoVien.DataSource, "NoiSinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", dtgGiaoVien.DataSource, "CMND");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dtgGiaoVien.DataSource, "DiaChi");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("text", dtgGiaoVien.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dtgGiaoVien.DataSource, "Email");
            txtMS.DataBindings.Clear();
            txtMS.DataBindings.Add("text", dtgGiaoVien.DataSource, "MaGiaoVien");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_DSGV_Quydinhtuoi ql_dsgv_qdt = new QL_DSGV_Quydinhtuoi();
            ql_dsgv_qdt.Show();
        }

        private void button_SuaHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Update_GiaoVien(txtMS.Text, txtHoTen.Text, cbGioiTinh.Text, dateTimePicker_NgSinh.Value,
            txtNoiSinh.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text, txtMaMon.Text);
            qlhs.SubmitChanges();
        }

        private void button_XoaHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Delete_GiaoVien(txtMS.Text);
            qlhs.SubmitChanges();
        }
    }
}
