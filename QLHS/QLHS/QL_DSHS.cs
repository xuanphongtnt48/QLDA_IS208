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
    
    public partial class QL_DSHS : Form
    {
        DataQLHSDataContext qlhs;
        public QL_DSHS()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            dtgHocSinh.DataSource = qlhs.select_HocSinh(cbChonLop.Text, cbChonKhoi.Text);
            for (int i = 0; i < dtgHocSinh.Rows.Count; i++)
            {
                if (dtgHocSinh.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgHocSinh.Rows[i].Cells[0].Value = i + 1;
                }
            }
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dtgHocSinh.DataSource, "TenHocSinh");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("text", dtgHocSinh.DataSource, "GioiTinh");
            dateTimePicker_NgSinh.DataBindings.Clear();
            dateTimePicker_NgSinh.DataBindings.Add("text", dtgHocSinh.DataSource, "NgaySinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("text", dtgHocSinh.DataSource, "NoiSinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", dtgHocSinh.DataSource, "CMND");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dtgHocSinh.DataSource, "DiaChi");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("text", dtgHocSinh.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dtgHocSinh.DataSource, "Email");
            txtMS.DataBindings.Clear();
            txtMS.DataBindings.Add("text", dtgHocSinh.DataSource, "MaGiaoVien");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_DSHS_Quydinhtuoi ql_dshs_qdt = new QL_DSHS_Quydinhtuoi();
            ql_dshs_qdt.Show();
        }

        private void QL_DSHS_Load(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            cbChonKhoi.DisplayMember = "MaKhoi";
            //cbChonKhoi.ValueMember = "";
            cbChonKhoi.DataSource = qlhs.KHOIs;
            cbChonLop.DisplayMember = "MaLop";
            //cbChonKhoi.ValueMember = "";
            cbChonLop.DataSource = qlhs.LOPs;
            //dtgLop.DataSource = qlhs.select_AllLop();
        }

        private void comboBox_Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_NgSinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_ThemHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            //HOCSINH hs = new HOCSINH();
            //hs.CMND=int.Parse(txtCMND.Text);
            try
            {
                //qlhs.Insert_HOCSINH(txtMS.Text, txtHoTen.Text, cbGioiTinh.Text, dateTimePicker_NgSinh.Value, txtNoiSinh.Text, txtCMND.Text, txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text);
                qlhs.Insert_HOCSINH(txtMS.Text, txtHoTen.Text, cbGioiTinh.Text, dateTimePicker_NgSinh.Value,
                    txtNoiSinh.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text);
                qlhs.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("học sinh bạn muốn thêm đã có trong danh sách, không thể thêm mới");
            }

        }

        private void button_XoaHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Delete_HOCSINHXL(txtMS.Text);
            qlhs.Delete_HOCSINH(txtMS.Text);
            qlhs.SubmitChanges();
        }

        private void button_SuaHS_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            qlhs.Update_HOCSINH(txtMS.Text, txtHoTen.Text, cbGioiTinh.Text, dateTimePicker_NgSinh.Value,
                    txtNoiSinh.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text);
            qlhs.SubmitChanges();
        }
    }
}
