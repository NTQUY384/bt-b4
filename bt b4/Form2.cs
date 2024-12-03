using System;
using System.Windows.Forms;

namespace bt_b4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string MSNV { get; set; }
        public string TENNV { get; set; }
        public string LCB { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMsnv.Text) ||
                string.IsNullOrWhiteSpace(txtTennv.Text) ||
                string.IsNullOrWhiteSpace(txtLuongcb.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                return;
            }

            if (!decimal.TryParse(txtLuongcb.Text, out _))
            {
                MessageBox.Show("Lương cơ bản phải là số.", "Thông báo");
                return;
            }

            MSNV = txtMsnv.Text;
            TENNV = txtTennv.Text;
            LCB = txtLuongcb.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
