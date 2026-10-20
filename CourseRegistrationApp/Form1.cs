using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var courses = new List<Course>
            {
                new Course { Name = "C# WinForms cơ bản", Fee = 800000 },
                new Course { Name = "SQL Server cơ bản", Fee = 700000 },
                new Course { Name = "Web Frontend cơ bản", Fee = 750000 },
                new Course { Name = "Lập trình Python cơ bản", Fee = 650000 }
            };
            
            cboKhoaHoc.DataSource = courses;
            
            cboKhoaHoc.DisplayMember = Name;
            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            lblTongTien.Text = courses[0].Fee.ToString();
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course SelectedCourse = (Course)cboKhoaHoc.SelectedItem;
            lblTongTien.Text = (SelectedCourse.Fee * numSoThang.Value).ToString();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException(); // Same method as choosing new course in course combo box (check in form.designer.cs)
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập tên!");
            }

            else if (txtSoDienThoai.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!");
            }

            else
            {
                MessageBox.Show(
                    $"THÔNG TIN ĐĂNG KÝ \n" +
                    $"Họ tên: {txtHoTen.Text} \n" +
                    $"Số điện thoại: {txtSoDienThoai.Text} \n" +
                    $"Ngày sinh: {dtpNgaySinh.Value} \n" +
                    $"Khoá học: {cboKhoaHoc.SelectedItem} \n" +
                    "Hình thức học: " +
                    (radOnline.Checked==true?"Online":"Trực tiếp") + "\n" +
                    $"Số tháng: {numSoThang.Value}\n" +
                    $"Tổng tiền: {lblTongTien.Text} VND\n" +
                    "Trạng thái nhận mail: " + (chkNhanEmail.Checked==true?"Nhận":"Không nhận")
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = null;
            txtSoDienThoai.Text = null;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            radOffline.Checked = false;
            numSoThang.Value = 1;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc muốn thoát khỏi ứng dụng?";
            string title = "XÁC NHẬN THOÁT";
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Đã thoát khỏi ứng dụng.", "Đã thoát", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}