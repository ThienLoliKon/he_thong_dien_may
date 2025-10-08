namespace he_thong_dien_may
{
	partial class frmSanPham
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
			this.metroListBox1 = new ReaLTaiizor.Controls.MetroListBox();
			this.button1 = new ReaLTaiizor.Controls.Button();
			this.SuspendLayout();
			// 
			// metroListBox1
			// 
			this.metroListBox1.BackColor = System.Drawing.Color.White;
			this.metroListBox1.BorderColor = System.Drawing.Color.LightGray;
			this.metroListBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.metroListBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			this.metroListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.metroListBox1.HoveredItemBackColor = System.Drawing.Color.LightGray;
			this.metroListBox1.HoveredItemColor = System.Drawing.Color.DimGray;
			this.metroListBox1.IsDerivedStyle = true;
			this.metroListBox1.ItemHeight = 30;
			this.metroListBox1.Location = new System.Drawing.Point(238, 38);
			this.metroListBox1.MultiSelect = false;
			this.metroListBox1.Name = "metroListBox1";
			this.metroListBox1.SelectedIndex = -1;
			this.metroListBox1.SelectedItem = null;
			this.metroListBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.metroListBox1.SelectedItemColor = System.Drawing.Color.White;
			this.metroListBox1.SelectedText = null;
			this.metroListBox1.SelectedValue = null;
			this.metroListBox1.ShowBorder = false;
			this.metroListBox1.ShowScrollBar = false;
			this.metroListBox1.Size = new System.Drawing.Size(75, 23);
			this.metroListBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
			this.metroListBox1.StyleManager = null;
			this.metroListBox1.TabIndex = 1;
			this.metroListBox1.ThemeAuthor = "Taiizor";
			this.metroListBox1.ThemeName = "MetroLight";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.Image = null;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.button1.Location = new System.Drawing.Point(214, 252);
			this.button1.Name = "button1";
			this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button1.Size = new System.Drawing.Size(120, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.metroListBox1);
			this.Name = "frmSanPham";
			this.Text = "frmSanPham";
			this.ResumeLayout(false);

		}

		#endregion

		private ReaLTaiizor.Controls.MetroListBox metroListBox1;
		private ReaLTaiizor.Controls.Button button1;
	}
}