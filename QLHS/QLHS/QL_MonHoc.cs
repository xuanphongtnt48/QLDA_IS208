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
    public partial class QL_MonHoc : Form
    {
        DataQLHSDataContext qlhs;
        public QL_MonHoc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TenMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void QL_MonHoc_Load(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            dtgMonHoc.DataSource = qlhs.MONHOCs;
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("text", dtgMonHoc.DataSource, "MaMon");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("text", dtgMonHoc.DataSource, "TenMon");
            for (int i = 0; i < dtgMonHoc.Rows.Count; i++)
            {
                if (dtgMonHoc.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgMonHoc.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            MONHOC newmonhoc = new MONHOC();
            newmonhoc.MaMon = txtMaMH.Text;
            newmonhoc.TenMon = txtTenMH.Text;
            //if (newmonhoc.MaMon == qlhs.MONHOCs.
            try
            {
                qlhs.MONHOCs.InsertOnSubmit(newmonhoc);
                qlhs.SubmitChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Môn học bạn muốn thêm đã có trong danh sách, không thể thêm mới");
            }

            //qlhs.MONHOCs.InsertOnSubmit(newmonhoc);
            dtgMonHoc.DataSource = qlhs.MONHOCs;
            for (int i = 0; i < dtgMonHoc.Rows.Count; i++)
            {
                if (dtgMonHoc.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgMonHoc.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            MONHOC monhoc = new MONHOC();
            monhoc.MaMon = txtMaMH.Text;
            monhoc.TenMon = txtTenMH.Text;
            qlhs.Update_MONHOC(monhoc.MaMon,monhoc.TenMon);
            qlhs.SubmitChanges();
            dtgMonHoc.DataSource = qlhs.MONHOCs;
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("text", dtgMonHoc.DataSource, "MaMon");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("text", dtgMonHoc.DataSource, "TenMon");
            for (int i = 0; i < dtgMonHoc.Rows.Count; i++)
            {
                if (dtgMonHoc.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgMonHoc.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qlhs = new DataQLHSDataContext();
            MONHOC monhoc = new MONHOC();
            monhoc.MaMon = txtMaMH.Text;
            qlhs.Delete_MONHOC(monhoc.MaMon);
            qlhs.SubmitChanges();
            dtgMonHoc.DataSource = qlhs.MONHOCs;
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("text", dtgMonHoc.DataSource, "MaMon");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("text", dtgMonHoc.DataSource, "TenMon");
            for (int i = 0; i < dtgMonHoc.Rows.Count; i++)
            {
                if (dtgMonHoc.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu 
                {
                    dtgMonHoc.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }
    }
}
