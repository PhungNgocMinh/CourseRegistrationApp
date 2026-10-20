namespace CourseRegistrationApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.AccessibleName = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(151, 116);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AccessibleName = "txtSoDienThoai";
            this.txtSoDienThoai.Location = new System.Drawing.Point(151, 165);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(166, 20);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.AccessibleName = "dtpNgaySinh";
            this.dtpNgaySinh.Location = new System.Drawing.Point(151, 218);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(166, 20);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(2026, 10, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth date:";
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AccessibleName = "chkNhanEmail";
            this.chkNhanEmail.Location = new System.Drawing.Point(45, 268);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(181, 24);
            this.chkNhanEmail.TabIndex = 6;
            this.chkNhanEmail.Text = "Recieve news and promotions";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.AccessibleName = "cboKhoaHoc";
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(578, 113);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(121, 21);
            this.cboKhoaHoc.TabIndex = 7;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(472, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course:";
            // 
            // radOnline
            // 
            this.radOnline.AccessibleName = "radOnline";
            this.radOnline.Location = new System.Drawing.Point(578, 161);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(104, 20);
            this.radOnline.TabIndex = 9;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            // 
            // radOffline
            // 
            this.radOffline.AccessibleName = "radOffline";
            this.radOffline.Location = new System.Drawing.Point(640, 161);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(104, 20);
            this.radOffline.TabIndex = 10;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Offline";
            this.radOffline.UseVisualStyleBackColor = true;
            // 
            // numSoThang
            // 
            this.numSoThang.AccessibleName = "numSoThang";
            this.numSoThang.Location = new System.Drawing.Point(578, 216);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 20);
            this.numSoThang.TabIndex = 11;
            this.numSoThang.ValueChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(472, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Duration (month):";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(472, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tuition fee (VND):";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(472, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Study format:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AccessibleName = "lblTongTien";
            this.lblTongTien.Location = new System.Drawing.Point(578, 268);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 24);
            this.lblTongTien.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(45, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "STUDENT\'S INFORMATION";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(472, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "COURSE INFORMATION";
            // 
            // btnDangKy
            // 
            this.btnDangKy.AccessibleName = "btnDangKy";
            this.btnDangKy.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDangKy.Location = new System.Drawing.Point(357, 335);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 18;
            this.btnDangKy.Text = "Sign up";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AccessibleName = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(578, 401);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Refresh";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleName = "btnThoat";
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.Location = new System.Drawing.Point(694, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "lblTongTien";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSoThang);
            this.Controls.Add(this.radOffline);
            this.Controls.Add(this.radOnline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboKhoaHoc);
            this.Controls.Add(this.chkNhanEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cboKhoaHoc;

        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Button btnDangKy;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.NumericUpDown numSoThang;

        private System.Windows.Forms.RadioButton radOffline;

        private System.Windows.Forms.RadioButton radOnline;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.CheckBox chkNhanEmail;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;

        private System.Windows.Forms.TextBox txtSoDienThoai;

        private System.Windows.Forms.TextBox txtHoTen;

        #endregion
    }
}