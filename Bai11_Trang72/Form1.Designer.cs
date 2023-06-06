namespace Bai11_Trang72
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSĐT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstMatHang = new System.Windows.Forms.ListBox();
			this.lstGioHang = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoTheNganHang = new System.Windows.Forms.RadioButton();
			this.rdoZalopay = new System.Windows.Forms.RadioButton();
			this.rdoTienMat = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ckbEmail = new System.Windows.Forms.CheckBox();
			this.ckbFax = new System.Windows.Forms.CheckBox();
			this.ckbDienThoai = new System.Windows.Forms.CheckBox();
			this.btnDongY = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên:";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(106, 15);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(352, 22);
			this.txtHoTen.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(532, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Phone:";
			// 
			// txtSĐT
			// 
			this.txtSĐT.Location = new System.Drawing.Point(623, 16);
			this.txtSĐT.Name = "txtSĐT";
			this.txtSĐT.Size = new System.Drawing.Size(352, 22);
			this.txtSĐT.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(532, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Giỏ hàng:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(235, 29);
			this.label4.TabIndex = 5;
			this.label4.Text = "Danh sách mặt hàng:";
			// 
			// lstMatHang
			// 
			this.lstMatHang.FormattingEnabled = true;
			this.lstMatHang.ItemHeight = 16;
			this.lstMatHang.Location = new System.Drawing.Point(19, 114);
			this.lstMatHang.Name = "lstMatHang";
			this.lstMatHang.Size = new System.Drawing.Size(438, 292);
			this.lstMatHang.TabIndex = 6;
			this.lstMatHang.DoubleClick += new System.EventHandler(this.lstMatHang_DoubleClick);
			// 
			// lstGioHang
			// 
			this.lstGioHang.FormattingEnabled = true;
			this.lstGioHang.ItemHeight = 16;
			this.lstGioHang.Location = new System.Drawing.Point(537, 114);
			this.lstGioHang.Name = "lstGioHang";
			this.lstGioHang.Size = new System.Drawing.Size(438, 292);
			this.lstGioHang.TabIndex = 7;
			this.lstGioHang.DoubleClick += new System.EventHandler(this.lstGioHang_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoTheNganHang);
			this.groupBox1.Controls.Add(this.rdoZalopay);
			this.groupBox1.Controls.Add(this.rdoTienMat);
			this.groupBox1.Location = new System.Drawing.Point(20, 428);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(437, 213);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hình thức thanh toán";
			// 
			// rdoTheNganHang
			// 
			this.rdoTheNganHang.AutoSize = true;
			this.rdoTheNganHang.Location = new System.Drawing.Point(26, 165);
			this.rdoTheNganHang.Name = "rdoTheNganHang";
			this.rdoTheNganHang.Size = new System.Drawing.Size(118, 20);
			this.rdoTheNganHang.TabIndex = 2;
			this.rdoTheNganHang.TabStop = true;
			this.rdoTheNganHang.Text = "Thẻ ngân hàng";
			this.rdoTheNganHang.UseVisualStyleBackColor = true;
			// 
			// rdoZalopay
			// 
			this.rdoZalopay.AutoSize = true;
			this.rdoZalopay.Location = new System.Drawing.Point(26, 97);
			this.rdoZalopay.Name = "rdoZalopay";
			this.rdoZalopay.Size = new System.Drawing.Size(78, 20);
			this.rdoZalopay.TabIndex = 1;
			this.rdoZalopay.TabStop = true;
			this.rdoZalopay.Text = "Zalopay";
			this.rdoZalopay.UseVisualStyleBackColor = true;
			// 
			// rdoTienMat
			// 
			this.rdoTienMat.AutoSize = true;
			this.rdoTienMat.Location = new System.Drawing.Point(26, 30);
			this.rdoTienMat.Name = "rdoTienMat";
			this.rdoTienMat.Size = new System.Drawing.Size(80, 20);
			this.rdoTienMat.TabIndex = 0;
			this.rdoTienMat.TabStop = true;
			this.rdoTienMat.Text = "Tiền mặt";
			this.rdoTienMat.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ckbEmail);
			this.groupBox2.Controls.Add(this.ckbFax);
			this.groupBox2.Controls.Add(this.ckbDienThoai);
			this.groupBox2.Location = new System.Drawing.Point(537, 428);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(437, 213);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hình thức liên lạc";
			// 
			// ckbEmail
			// 
			this.ckbEmail.AutoSize = true;
			this.ckbEmail.Location = new System.Drawing.Point(49, 165);
			this.ckbEmail.Name = "ckbEmail";
			this.ckbEmail.Size = new System.Drawing.Size(63, 20);
			this.ckbEmail.TabIndex = 2;
			this.ckbEmail.Text = "Email";
			this.ckbEmail.UseVisualStyleBackColor = true;
			// 
			// ckbFax
			// 
			this.ckbFax.AutoSize = true;
			this.ckbFax.Location = new System.Drawing.Point(49, 98);
			this.ckbFax.Name = "ckbFax";
			this.ckbFax.Size = new System.Drawing.Size(51, 20);
			this.ckbFax.TabIndex = 1;
			this.ckbFax.Text = "Fax";
			this.ckbFax.UseVisualStyleBackColor = true;
			// 
			// ckbDienThoai
			// 
			this.ckbDienThoai.AutoSize = true;
			this.ckbDienThoai.Location = new System.Drawing.Point(49, 37);
			this.ckbDienThoai.Name = "ckbDienThoai";
			this.ckbDienThoai.Size = new System.Drawing.Size(88, 20);
			this.ckbDienThoai.TabIndex = 0;
			this.ckbDienThoai.Text = "Điện thoại";
			this.ckbDienThoai.UseVisualStyleBackColor = true;
			// 
			// btnDongY
			// 
			this.btnDongY.Location = new System.Drawing.Point(22, 666);
			this.btnDongY.Name = "btnDongY";
			this.btnDongY.Size = new System.Drawing.Size(435, 45);
			this.btnDongY.TabIndex = 10;
			this.btnDongY.Text = "&Đồng ý";
			this.btnDongY.UseVisualStyleBackColor = true;
			this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(537, 666);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(438, 45);
			this.btnThoat.TabIndex = 11;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(997, 734);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDongY);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstGioHang);
			this.Controls.Add(this.lstMatHang);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSĐT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mua sách online";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.ListBox lstGioHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTheNganHang;
        private System.Windows.Forms.RadioButton rdoZalopay;
        private System.Windows.Forms.RadioButton rdoTienMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.CheckBox ckbFax;
        private System.Windows.Forms.CheckBox ckbDienThoai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
    }
}

