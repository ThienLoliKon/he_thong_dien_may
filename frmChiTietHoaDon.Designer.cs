﻿namespace he_thong_dien_may
{
	partial class frmChiTietHoaDon
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
			this.txtSoLuong = new ReaLTaiizor.Controls.ForeverTextBox();
			this.choNhanVienLap = new ReaLTaiizor.Controls.HopeComboBox();
			this.dtpNgayGioIn = new ReaLTaiizor.Controls.PoisonDateTime();
			this.foreverLabel8 = new ReaLTaiizor.Controls.ForeverLabel();
			this.dgvSanPham = new ReaLTaiizor.Controls.PoisonDataGridView();
			this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
			this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
			this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
			this.txtMaHoaDon = new ReaLTaiizor.Controls.ForeverTextBox();
			this.btnXoa = new ReaLTaiizor.Controls.CyberButton();
			this.btnTimKiem = new ReaLTaiizor.Controls.CyberButton();
			this.btnThoat = new ReaLTaiizor.Controls.CyberButton();
			this.btnSua = new ReaLTaiizor.Controls.CyberButton();
			this.btnThem = new ReaLTaiizor.Controls.CyberButton();
			this.foreverForm1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// foreverForm1
			// 
			this.foreverForm1.BackColor = System.Drawing.Color.White;
			this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
			this.foreverForm1.Controls.Add(this.btnXoa);
			this.foreverForm1.Controls.Add(this.btnTimKiem);
			this.foreverForm1.Controls.Add(this.btnThoat);
			this.foreverForm1.Controls.Add(this.btnSua);
			this.foreverForm1.Controls.Add(this.btnThem);
			this.foreverForm1.Controls.Add(this.txtSoLuong);
			this.foreverForm1.Controls.Add(this.choNhanVienLap);
			this.foreverForm1.Controls.Add(this.dtpNgayGioIn);
			this.foreverForm1.Controls.Add(this.foreverLabel8);
			this.foreverForm1.Controls.Add(this.dgvSanPham);
			this.foreverForm1.Controls.Add(this.foreverLabel3);
			this.foreverForm1.Controls.Add(this.foreverLabel2);
			this.foreverForm1.Controls.Add(this.foreverLabel1);
			this.foreverForm1.Controls.Add(this.txtMaHoaDon);
			this.foreverForm1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.foreverForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.foreverForm1.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.foreverForm1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.foreverForm1.HeaderMaximize = false;
			this.foreverForm1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
			this.foreverForm1.Image = null;
			this.foreverForm1.Location = new System.Drawing.Point(0, 0);
			this.foreverForm1.MinimumSize = new System.Drawing.Size(210, 50);
			this.foreverForm1.Name = "foreverForm1";
			this.foreverForm1.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
			this.foreverForm1.Sizable = true;
			this.foreverForm1.Size = new System.Drawing.Size(1782, 753);
			this.foreverForm1.TabIndex = 0;
			this.foreverForm1.Text = "Chi Tiết Đơn Hàng";
			this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
			this.foreverForm1.Click += new System.EventHandler(this.foreverForm1_Click);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
			this.txtSoLuong.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.txtSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.txtSoLuong.FocusOnHover = false;
			this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtSoLuong.Location = new System.Drawing.Point(958, 72);
			this.txtSoLuong.MaxLength = 32767;
			this.txtSoLuong.Multiline = false;
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.ReadOnly = false;
			this.txtSoLuong.Size = new System.Drawing.Size(200, 34);
			this.txtSoLuong.TabIndex = 58;
			this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSoLuong.UseSystemPasswordChar = false;
			// 
			// choNhanVienLap
			// 
			this.choNhanVienLap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.choNhanVienLap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.choNhanVienLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.choNhanVienLap.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.choNhanVienLap.FormattingEnabled = true;
			this.choNhanVienLap.ItemHeight = 30;
			this.choNhanVienLap.Location = new System.Drawing.Point(485, 135);
			this.choNhanVienLap.Name = "choNhanVienLap";
			this.choNhanVienLap.Size = new System.Drawing.Size(200, 36);
			this.choNhanVienLap.TabIndex = 57;
			// 
			// dtpNgayGioIn
			// 
			this.dtpNgayGioIn.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
			this.dtpNgayGioIn.Location = new System.Drawing.Point(1451, 76);
			this.dtpNgayGioIn.MinimumSize = new System.Drawing.Size(0, 30);
			this.dtpNgayGioIn.Name = "dtpNgayGioIn";
			this.dtpNgayGioIn.Size = new System.Drawing.Size(200, 30);
			this.dtpNgayGioIn.TabIndex = 53;
			// 
			// foreverLabel8
			// 
			this.foreverLabel8.AutoSize = true;
			this.foreverLabel8.BackColor = System.Drawing.Color.Transparent;
			this.foreverLabel8.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.foreverLabel8.ForeColor = System.Drawing.Color.LightGray;
			this.foreverLabel8.Location = new System.Drawing.Point(1328, 85);
			this.foreverLabel8.Name = "foreverLabel8";
			this.foreverLabel8.Size = new System.Drawing.Size(86, 19);
			this.foreverLabel8.TabIndex = 52;
			this.foreverLabel8.Text = "Ngày giờ in :";
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AllowUserToResizeRows = false;
			this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvSanPham.EnableHeadersVisualStyles = false;
			this.dgvSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSanPham.Location = new System.Drawing.Point(1, 352);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSanPham.RowHeadersWidth = 51;
			this.dgvSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSanPham.RowTemplate.Height = 24;
			this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSanPham.Size = new System.Drawing.Size(1780, 400);
			this.dgvSanPham.TabIndex = 50;
			// 
			// foreverLabel3
			// 
			this.foreverLabel3.AutoSize = true;
			this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
			this.foreverLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.foreverLabel3.ForeColor = System.Drawing.Color.LightGray;
			this.foreverLabel3.Location = new System.Drawing.Point(844, 84);
			this.foreverLabel3.Name = "foreverLabel3";
			this.foreverLabel3.Size = new System.Drawing.Size(70, 19);
			this.foreverLabel3.TabIndex = 46;
			this.foreverLabel3.Text = "Số lượng :";
			// 
			// foreverLabel2
			// 
			this.foreverLabel2.AutoSize = true;
			this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
			this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
			this.foreverLabel2.Location = new System.Drawing.Point(360, 147);
			this.foreverLabel2.Name = "foreverLabel2";
			this.foreverLabel2.Size = new System.Drawing.Size(77, 19);
			this.foreverLabel2.TabIndex = 44;
			this.foreverLabel2.Text = "Sản Phâm :";
			// 
			// foreverLabel1
			// 
			this.foreverLabel1.AutoSize = true;
			this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
			this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
			this.foreverLabel1.Location = new System.Drawing.Point(360, 84);
			this.foreverLabel1.Name = "foreverLabel1";
			this.foreverLabel1.Size = new System.Drawing.Size(91, 19);
			this.foreverLabel1.TabIndex = 42;
			this.foreverLabel1.Text = "Mã hóa đơn :";
			// 
			// txtMaHoaDon
			// 
			this.txtMaHoaDon.BackColor = System.Drawing.Color.Transparent;
			this.txtMaHoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.txtMaHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.txtMaHoaDon.FocusOnHover = false;
			this.txtMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtMaHoaDon.Location = new System.Drawing.Point(485, 69);
			this.txtMaHoaDon.MaxLength = 32767;
			this.txtMaHoaDon.Multiline = false;
			this.txtMaHoaDon.Name = "txtMaHoaDon";
			this.txtMaHoaDon.ReadOnly = false;
			this.txtMaHoaDon.Size = new System.Drawing.Size(200, 34);
			this.txtMaHoaDon.TabIndex = 41;
			this.txtMaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtMaHoaDon.UseSystemPasswordChar = false;
			// 
			// btnXoa
			// 
			this.btnXoa.Alpha = 20;
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.Background = true;
			this.btnXoa.Background_WidthPen = 4F;
			this.btnXoa.BackgroundPen = true;
			this.btnXoa.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnXoa.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnXoa.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnXoa.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnXoa.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnXoa.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnXoa.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnXoa.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			this.btnXoa.Effect_1 = true;
			this.btnXoa.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnXoa.Effect_1_Transparency = 25;
			this.btnXoa.Effect_2 = true;
			this.btnXoa.Effect_2_ColorBackground = System.Drawing.Color.White;
			this.btnXoa.Effect_2_Transparency = 20;
			this.btnXoa.Font = new System.Drawing.Font("Arial", 11F);
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
			this.btnXoa.Lighting = false;
			this.btnXoa.LinearGradient_Background = false;
			this.btnXoa.LinearGradientPen = false;
			this.btnXoa.Location = new System.Drawing.Point(755, 226);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.PenWidth = 15;
			this.btnXoa.Rounding = true;
			this.btnXoa.RoundingInt = 70;
			this.btnXoa.Size = new System.Drawing.Size(130, 50);
			this.btnXoa.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.btnXoa.TabIndex = 63;
			this.btnXoa.Tag = "Cyber";
			this.btnXoa.TextButton = "Xóa";
			this.btnXoa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnXoa.Timer_Effect_1 = 5;
			this.btnXoa.Timer_RGB = 300;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Alpha = 20;
			this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
			this.btnTimKiem.Background = true;
			this.btnTimKiem.Background_WidthPen = 4F;
			this.btnTimKiem.BackgroundPen = true;
			this.btnTimKiem.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnTimKiem.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnTimKiem.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnTimKiem.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnTimKiem.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnTimKiem.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnTimKiem.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnTimKiem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			this.btnTimKiem.Effect_1 = true;
			this.btnTimKiem.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnTimKiem.Effect_1_Transparency = 25;
			this.btnTimKiem.Effect_2 = true;
			this.btnTimKiem.Effect_2_ColorBackground = System.Drawing.Color.White;
			this.btnTimKiem.Effect_2_Transparency = 20;
			this.btnTimKiem.Font = new System.Drawing.Font("Arial", 11F);
			this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
			this.btnTimKiem.Lighting = false;
			this.btnTimKiem.LinearGradient_Background = false;
			this.btnTimKiem.LinearGradientPen = false;
			this.btnTimKiem.Location = new System.Drawing.Point(1265, 226);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.PenWidth = 15;
			this.btnTimKiem.Rounding = true;
			this.btnTimKiem.RoundingInt = 70;
			this.btnTimKiem.Size = new System.Drawing.Size(130, 50);
			this.btnTimKiem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.btnTimKiem.TabIndex = 62;
			this.btnTimKiem.Tag = "Cyber";
			this.btnTimKiem.TextButton = "Tìm Kiếm";
			this.btnTimKiem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnTimKiem.Timer_Effect_1 = 5;
			this.btnTimKiem.Timer_RGB = 300;
			// 
			// btnThoat
			// 
			this.btnThoat.Alpha = 20;
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.Background = true;
			this.btnThoat.Background_WidthPen = 4F;
			this.btnThoat.BackgroundPen = true;
			this.btnThoat.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThoat.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThoat.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnThoat.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThoat.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThoat.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThoat.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnThoat.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			this.btnThoat.Effect_1 = true;
			this.btnThoat.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThoat.Effect_1_Transparency = 25;
			this.btnThoat.Effect_2 = true;
			this.btnThoat.Effect_2_ColorBackground = System.Drawing.Color.White;
			this.btnThoat.Effect_2_Transparency = 20;
			this.btnThoat.Font = new System.Drawing.Font("Arial", 11F);
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
			this.btnThoat.Lighting = false;
			this.btnThoat.LinearGradient_Background = false;
			this.btnThoat.LinearGradientPen = false;
			this.btnThoat.Location = new System.Drawing.Point(1501, 226);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.PenWidth = 15;
			this.btnThoat.Rounding = true;
			this.btnThoat.RoundingInt = 70;
			this.btnThoat.Size = new System.Drawing.Size(130, 50);
			this.btnThoat.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.btnThoat.TabIndex = 61;
			this.btnThoat.Tag = "Cyber";
			this.btnThoat.TextButton = "Thoát";
			this.btnThoat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnThoat.Timer_Effect_1 = 5;
			this.btnThoat.Timer_RGB = 300;
			// 
			// btnSua
			// 
			this.btnSua.Alpha = 20;
			this.btnSua.BackColor = System.Drawing.Color.Transparent;
			this.btnSua.Background = true;
			this.btnSua.Background_WidthPen = 4F;
			this.btnSua.BackgroundPen = true;
			this.btnSua.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnSua.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnSua.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnSua.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnSua.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnSua.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnSua.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnSua.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			this.btnSua.Effect_1 = true;
			this.btnSua.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnSua.Effect_1_Transparency = 25;
			this.btnSua.Effect_2 = true;
			this.btnSua.Effect_2_ColorBackground = System.Drawing.Color.White;
			this.btnSua.Effect_2_Transparency = 20;
			this.btnSua.Font = new System.Drawing.Font("Arial", 11F);
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
			this.btnSua.Lighting = false;
			this.btnSua.LinearGradient_Background = false;
			this.btnSua.LinearGradientPen = false;
			this.btnSua.Location = new System.Drawing.Point(1010, 226);
			this.btnSua.Name = "btnSua";
			this.btnSua.PenWidth = 15;
			this.btnSua.Rounding = true;
			this.btnSua.RoundingInt = 70;
			this.btnSua.Size = new System.Drawing.Size(130, 50);
			this.btnSua.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.btnSua.TabIndex = 60;
			this.btnSua.Tag = "Cyber";
			this.btnSua.TextButton = "Sửa";
			this.btnSua.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnSua.Timer_Effect_1 = 5;
			this.btnSua.Timer_RGB = 300;
			// 
			// btnThem
			// 
			this.btnThem.Alpha = 20;
			this.btnThem.BackColor = System.Drawing.Color.Transparent;
			this.btnThem.Background = true;
			this.btnThem.Background_WidthPen = 4F;
			this.btnThem.BackgroundPen = true;
			this.btnThem.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThem.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThem.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnThem.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThem.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThem.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
			this.btnThem.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
			this.btnThem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			this.btnThem.Effect_1 = true;
			this.btnThem.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
			this.btnThem.Effect_1_Transparency = 25;
			this.btnThem.Effect_2 = true;
			this.btnThem.Effect_2_ColorBackground = System.Drawing.Color.White;
			this.btnThem.Effect_2_Transparency = 20;
			this.btnThem.Font = new System.Drawing.Font("Arial", 11F);
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
			this.btnThem.Lighting = false;
			this.btnThem.LinearGradient_Background = false;
			this.btnThem.LinearGradientPen = false;
			this.btnThem.Location = new System.Drawing.Point(512, 226);
			this.btnThem.Name = "btnThem";
			this.btnThem.PenWidth = 15;
			this.btnThem.Rounding = true;
			this.btnThem.RoundingInt = 70;
			this.btnThem.Size = new System.Drawing.Size(130, 50);
			this.btnThem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.btnThem.TabIndex = 59;
			this.btnThem.Tag = "Cyber";
			this.btnThem.TextButton = "Thêm";
			this.btnThem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnThem.Timer_Effect_1 = 5;
			this.btnThem.Timer_RGB = 300;
			// 
			// frmChiTietHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1782, 753);
			this.Controls.Add(this.foreverForm1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmChiTietHoaDon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChiTietHoaDon";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.foreverForm1.ResumeLayout(false);
			this.foreverForm1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ReaLTaiizor.Forms.ForeverForm foreverForm1;
		private ReaLTaiizor.Controls.PoisonDateTime dtpNgayGioIn;
		private ReaLTaiizor.Controls.ForeverLabel foreverLabel8;
		private ReaLTaiizor.Controls.PoisonDataGridView dgvSanPham;
		private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
		private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
		private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
		private ReaLTaiizor.Controls.ForeverTextBox txtMaHoaDon;
		private ReaLTaiizor.Controls.HopeComboBox choNhanVienLap;
		private ReaLTaiizor.Controls.ForeverTextBox txtSoLuong;
		private ReaLTaiizor.Controls.CyberButton btnXoa;
		private ReaLTaiizor.Controls.CyberButton btnTimKiem;
		private ReaLTaiizor.Controls.CyberButton btnThoat;
		private ReaLTaiizor.Controls.CyberButton btnSua;
		private ReaLTaiizor.Controls.CyberButton btnThem;
	}
}