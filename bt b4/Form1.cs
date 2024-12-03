using System;
using System.Windows.Forms;

namespace bt_b4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập DataGridView để chọn toàn bộ hàng
            dvgNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Đảm bảo không thể chỉnh sửa trực tiếp trên các ô
            dvgNhanvien.AllowUserToAddRows = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 formNV = new Form2();
            formNV.Text = "Thêm Nhân Viên";

            if (formNV.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(formNV.MSNV) &&
                    !string.IsNullOrWhiteSpace(formNV.TENNV) &&
                    !string.IsNullOrWhiteSpace(formNV.LCB))
                {
                    dvgNhanvien.Rows.Add(formNV.MSNV, formNV.TENNV, formNV.LCB);
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ.", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dvgNhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow dongChon = dvgNhanvien.SelectedRows[0];
                Form2 formNV = new Form2
                {
                    Text = "Sửa Nhân Viên",
                    MSNV = dongChon.Cells[0].Value?.ToString(),
                    TENNV = dongChon.Cells[1].Value?.ToString(),
                    LCB = dongChon.Cells[2].Value?.ToString()
                };

                if (formNV.ShowDialog() == DialogResult.OK)
                {
                    dongChon.Cells[0].Value = formNV.MSNV;
                    dongChon.Cells[1].Value = formNV.TENNV;
                    dongChon.Cells[2].Value = formNV.LCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dvgNhanvien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dvgNhanvien.Rows.Remove(dvgNhanvien.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
