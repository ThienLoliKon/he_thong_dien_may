using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace he_thong_dien_may
{
	public partial class frmMainMenu : Form
	{
		public frmMainMenu()
		{
			InitializeComponent();
		}

		private void a_Load(object sender, EventArgs e)
		{
		//	Form childForm = new frmSanPham();
		//	childForm.MdiParent = this;
		//	childForm.Show();
		//Form childForm = new frmSanPham();
		//	
		}

		private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new frmSanPham();
			childForm.ShowDialog();
		}

	
	}
}
