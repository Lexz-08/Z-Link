using System;
using System.Windows.Forms;

namespace Z_Link
{
	public partial class AddLink : Form
	{
		public AddLink()
		{
			InitializeComponent();
		}

		private void LocationSelect_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Select a file to link...",
				Filter = "All Files|*.*",
				RestoreDirectory = true
			}) if (ofd.ShowDialog() == DialogResult.OK) txt_LinkLocation.Text = ofd.FileName;
		}

		private void IconSelect_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Select an icon to link...",
				Filter = "Display Icons|*.bmp; *.png; *.jpg; *.jpeg",
				RestoreDirectory = true
			}) if (ofd.ShowDialog() == DialogResult.OK) txt_LinkIcon.Text = ofd.FileName;
		}

		private void DialogControl_MouseEnter(object sender, EventArgs e)
		{
			((Control)sender).Cursor = Win32.GetHandCursor();
		}

		private void ConfirmLink_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelLink_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
