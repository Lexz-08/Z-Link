namespace Z_Link
{
	partial class Selector
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
			this.lst_ZLinks = new System.Windows.Forms.ListView();
			this.pic_RemoveLink = new System.Windows.Forms.PictureBox();
			this.pic_AddLink = new System.Windows.Forms.PictureBox();
			this.pic_ProgramDirectory = new System.Windows.Forms.PictureBox();
			this.pic_WindowMin = new System.Windows.Forms.PictureBox();
			this.pic_WindowClose = new System.Windows.Forms.PictureBox();
			this.pic_CreateLink = new System.Windows.Forms.PictureBox();
			this.icn_TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pic_RemoveLink)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_AddLink)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_ProgramDirectory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_WindowMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_WindowClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_CreateLink)).BeginInit();
			this.SuspendLayout();
			// 
			// lst_ZLinks
			// 
			this.lst_ZLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lst_ZLinks.HideSelection = false;
			this.lst_ZLinks.Location = new System.Drawing.Point(12, 12);
			this.lst_ZLinks.MultiSelect = false;
			this.lst_ZLinks.Name = "lst_ZLinks";
			this.lst_ZLinks.ShowGroups = false;
			this.lst_ZLinks.Size = new System.Drawing.Size(363, 144);
			this.lst_ZLinks.TabIndex = 3;
			this.lst_ZLinks.TileSize = new System.Drawing.Size(24, 24);
			this.lst_ZLinks.UseCompatibleStateImageBehavior = false;
			this.lst_ZLinks.SelectedIndexChanged += new System.EventHandler(this.ZLinks_SelectedIndexChanged);
			// 
			// pic_RemoveLink
			// 
			this.pic_RemoveLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_RemoveLink.Location = new System.Drawing.Point(35, 162);
			this.pic_RemoveLink.Name = "pic_RemoveLink";
			this.pic_RemoveLink.Size = new System.Drawing.Size(23, 23);
			this.pic_RemoveLink.TabIndex = 6;
			this.pic_RemoveLink.TabStop = false;
			this.pic_RemoveLink.Click += new System.EventHandler(this.RemoveLink_Click);
			this.pic_RemoveLink.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_RemoveLink.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// pic_AddLink
			// 
			this.pic_AddLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_AddLink.Location = new System.Drawing.Point(12, 162);
			this.pic_AddLink.Name = "pic_AddLink";
			this.pic_AddLink.Size = new System.Drawing.Size(23, 23);
			this.pic_AddLink.TabIndex = 5;
			this.pic_AddLink.TabStop = false;
			this.pic_AddLink.Click += new System.EventHandler(this.AddLink_Click);
			this.pic_AddLink.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_AddLink.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// pic_ProgramDirectory
			// 
			this.pic_ProgramDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_ProgramDirectory.Image = global::Z_Link.Properties.Resources.folder;
			this.pic_ProgramDirectory.Location = new System.Drawing.Point(306, 162);
			this.pic_ProgramDirectory.Name = "pic_ProgramDirectory";
			this.pic_ProgramDirectory.Size = new System.Drawing.Size(23, 23);
			this.pic_ProgramDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_ProgramDirectory.TabIndex = 4;
			this.pic_ProgramDirectory.TabStop = false;
			this.pic_ProgramDirectory.Click += new System.EventHandler(this.ProgramDir_Click);
			this.pic_ProgramDirectory.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_ProgramDirectory.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// pic_WindowMin
			// 
			this.pic_WindowMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_WindowMin.Location = new System.Drawing.Point(329, 162);
			this.pic_WindowMin.Name = "pic_WindowMin";
			this.pic_WindowMin.Size = new System.Drawing.Size(23, 23);
			this.pic_WindowMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pic_WindowMin.TabIndex = 2;
			this.pic_WindowMin.TabStop = false;
			this.pic_WindowMin.Click += new System.EventHandler(this.WindowMin_Click);
			this.pic_WindowMin.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_WindowMin.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// pic_WindowClose
			// 
			this.pic_WindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_WindowClose.Location = new System.Drawing.Point(352, 162);
			this.pic_WindowClose.Name = "pic_WindowClose";
			this.pic_WindowClose.Size = new System.Drawing.Size(23, 23);
			this.pic_WindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pic_WindowClose.TabIndex = 1;
			this.pic_WindowClose.TabStop = false;
			this.pic_WindowClose.Click += new System.EventHandler(this.WindowClose_Click);
			this.pic_WindowClose.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_WindowClose.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// pic_CreateLink
			// 
			this.pic_CreateLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_CreateLink.Image = global::Z_Link.Properties.Resources.link;
			this.pic_CreateLink.Location = new System.Drawing.Point(58, 162);
			this.pic_CreateLink.Name = "pic_CreateLink";
			this.pic_CreateLink.Size = new System.Drawing.Size(23, 23);
			this.pic_CreateLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_CreateLink.TabIndex = 7;
			this.pic_CreateLink.TabStop = false;
			this.pic_CreateLink.Click += new System.EventHandler(this.CreateLink_Click);
			this.pic_CreateLink.MouseEnter += new System.EventHandler(this.SelectorControl_MouseEnter);
			this.pic_CreateLink.MouseLeave += new System.EventHandler(this.SelectorControl_MouseLeave);
			// 
			// icn_TrayIcon
			// 
			this.icn_TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("icn_TrayIcon.Icon")));
			this.icn_TrayIcon.Text = "Z-Link";
			this.icn_TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
			// 
			// Selector
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(387, 197);
			this.Controls.Add(this.pic_CreateLink);
			this.Controls.Add(this.pic_RemoveLink);
			this.Controls.Add(this.pic_AddLink);
			this.Controls.Add(this.pic_ProgramDirectory);
			this.Controls.Add(this.lst_ZLinks);
			this.Controls.Add(this.pic_WindowMin);
			this.Controls.Add(this.pic_WindowClose);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Selector";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectorWindow_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pic_RemoveLink)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_AddLink)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_ProgramDirectory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_WindowMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_WindowClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_CreateLink)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pic_WindowClose;
		private System.Windows.Forms.PictureBox pic_WindowMin;
		private System.Windows.Forms.ListView lst_ZLinks;
		private System.Windows.Forms.PictureBox pic_ProgramDirectory;
		private System.Windows.Forms.PictureBox pic_AddLink;
		private System.Windows.Forms.PictureBox pic_RemoveLink;
		private System.Windows.Forms.PictureBox pic_CreateLink;
		private System.Windows.Forms.NotifyIcon icn_TrayIcon;
	}
}

