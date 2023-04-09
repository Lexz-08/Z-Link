namespace Z_Link
{
	partial class AddLink
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLink));
			this.lbl_LinkLocation = new System.Windows.Forms.Label();
			this.txt_LinkLocation = new System.Windows.Forms.TextBox();
			this.btn_LocationSelect = new System.Windows.Forms.Button();
			this.txt_LinkArgs = new System.Windows.Forms.TextBox();
			this.lbl_LinkArgs = new System.Windows.Forms.Label();
			this.btn_IconSelect = new System.Windows.Forms.Button();
			this.txt_LinkIcon = new System.Windows.Forms.TextBox();
			this.lbl_LinkIcon = new System.Windows.Forms.Label();
			this.btn_ConfirmLink = new System.Windows.Forms.Button();
			this.btn_CancelLink = new System.Windows.Forms.Button();
			this.txt_LinkName = new System.Windows.Forms.TextBox();
			this.lbl_LinkName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_LinkLocation
			// 
			this.lbl_LinkLocation.AutoSize = true;
			this.lbl_LinkLocation.Location = new System.Drawing.Point(5, 16);
			this.lbl_LinkLocation.Name = "lbl_LinkLocation";
			this.lbl_LinkLocation.Size = new System.Drawing.Size(56, 15);
			this.lbl_LinkLocation.TabIndex = 0;
			this.lbl_LinkLocation.Text = "Location:";
			// 
			// txt_LinkLocation
			// 
			this.txt_LinkLocation.Location = new System.Drawing.Point(80, 12);
			this.txt_LinkLocation.Name = "txt_LinkLocation";
			this.txt_LinkLocation.ReadOnly = true;
			this.txt_LinkLocation.Size = new System.Drawing.Size(251, 23);
			this.txt_LinkLocation.TabIndex = 1;
			// 
			// btn_LocationSelect
			// 
			this.btn_LocationSelect.Location = new System.Drawing.Point(337, 12);
			this.btn_LocationSelect.Name = "btn_LocationSelect";
			this.btn_LocationSelect.Size = new System.Drawing.Size(28, 23);
			this.btn_LocationSelect.TabIndex = 2;
			this.btn_LocationSelect.Text = "...";
			this.btn_LocationSelect.UseVisualStyleBackColor = true;
			this.btn_LocationSelect.Click += new System.EventHandler(this.LocationSelect_Click);
			this.btn_LocationSelect.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
			// 
			// txt_LinkArgs
			// 
			this.txt_LinkArgs.Location = new System.Drawing.Point(80, 41);
			this.txt_LinkArgs.Name = "txt_LinkArgs";
			this.txt_LinkArgs.Size = new System.Drawing.Size(285, 23);
			this.txt_LinkArgs.TabIndex = 4;
			// 
			// lbl_LinkArgs
			// 
			this.lbl_LinkArgs.AutoSize = true;
			this.lbl_LinkArgs.Location = new System.Drawing.Point(5, 45);
			this.lbl_LinkArgs.Name = "lbl_LinkArgs";
			this.lbl_LinkArgs.Size = new System.Drawing.Size(69, 15);
			this.lbl_LinkArgs.TabIndex = 3;
			this.lbl_LinkArgs.Text = "Arguments:";
			// 
			// btn_IconSelect
			// 
			this.btn_IconSelect.Location = new System.Drawing.Point(337, 70);
			this.btn_IconSelect.Name = "btn_IconSelect";
			this.btn_IconSelect.Size = new System.Drawing.Size(28, 23);
			this.btn_IconSelect.TabIndex = 7;
			this.btn_IconSelect.Text = "...";
			this.btn_IconSelect.UseVisualStyleBackColor = true;
			this.btn_IconSelect.Click += new System.EventHandler(this.IconSelect_Click);
			this.btn_IconSelect.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
			// 
			// txt_LinkIcon
			// 
			this.txt_LinkIcon.Location = new System.Drawing.Point(80, 70);
			this.txt_LinkIcon.Name = "txt_LinkIcon";
			this.txt_LinkIcon.ReadOnly = true;
			this.txt_LinkIcon.Size = new System.Drawing.Size(251, 23);
			this.txt_LinkIcon.TabIndex = 6;
			// 
			// lbl_LinkIcon
			// 
			this.lbl_LinkIcon.AutoSize = true;
			this.lbl_LinkIcon.Location = new System.Drawing.Point(5, 74);
			this.lbl_LinkIcon.Name = "lbl_LinkIcon";
			this.lbl_LinkIcon.Size = new System.Drawing.Size(33, 15);
			this.lbl_LinkIcon.TabIndex = 5;
			this.lbl_LinkIcon.Text = "Icon:";
			// 
			// btn_ConfirmLink
			// 
			this.btn_ConfirmLink.Location = new System.Drawing.Point(290, 128);
			this.btn_ConfirmLink.Name = "btn_ConfirmLink";
			this.btn_ConfirmLink.Size = new System.Drawing.Size(75, 23);
			this.btn_ConfirmLink.TabIndex = 8;
			this.btn_ConfirmLink.Text = "Confirm";
			this.btn_ConfirmLink.UseVisualStyleBackColor = true;
			this.btn_ConfirmLink.Click += new System.EventHandler(this.ConfirmLink_Click);
			this.btn_ConfirmLink.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
			// 
			// btn_CancelLink
			// 
			this.btn_CancelLink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_CancelLink.Location = new System.Drawing.Point(209, 128);
			this.btn_CancelLink.Name = "btn_CancelLink";
			this.btn_CancelLink.Size = new System.Drawing.Size(75, 23);
			this.btn_CancelLink.TabIndex = 9;
			this.btn_CancelLink.Text = "Cancel";
			this.btn_CancelLink.UseVisualStyleBackColor = true;
			this.btn_CancelLink.Click += new System.EventHandler(this.CancelLink_Click);
			this.btn_CancelLink.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
			// 
			// txt_LinkName
			// 
			this.txt_LinkName.Location = new System.Drawing.Point(80, 99);
			this.txt_LinkName.Name = "txt_LinkName";
			this.txt_LinkName.Size = new System.Drawing.Size(285, 23);
			this.txt_LinkName.TabIndex = 11;
			// 
			// lbl_LinkName
			// 
			this.lbl_LinkName.AutoSize = true;
			this.lbl_LinkName.Location = new System.Drawing.Point(5, 103);
			this.lbl_LinkName.Name = "lbl_LinkName";
			this.lbl_LinkName.Size = new System.Drawing.Size(42, 15);
			this.lbl_LinkName.TabIndex = 10;
			this.lbl_LinkName.Text = "Name:";
			// 
			// AddLink
			// 
			this.AcceptButton = this.btn_ConfirmLink;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btn_CancelLink;
			this.ClientSize = new System.Drawing.Size(377, 163);
			this.Controls.Add(this.txt_LinkName);
			this.Controls.Add(this.lbl_LinkName);
			this.Controls.Add(this.btn_CancelLink);
			this.Controls.Add(this.btn_ConfirmLink);
			this.Controls.Add(this.btn_IconSelect);
			this.Controls.Add(this.txt_LinkIcon);
			this.Controls.Add(this.lbl_LinkIcon);
			this.Controls.Add(this.txt_LinkArgs);
			this.Controls.Add(this.lbl_LinkArgs);
			this.Controls.Add(this.btn_LocationSelect);
			this.Controls.Add(this.txt_LinkLocation);
			this.Controls.Add(this.lbl_LinkLocation);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddLink";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Z-Link";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_LinkLocation;
		private System.Windows.Forms.Button btn_LocationSelect;
		private System.Windows.Forms.Label lbl_LinkArgs;
		private System.Windows.Forms.Button btn_IconSelect;
		private System.Windows.Forms.Label lbl_LinkIcon;
		private System.Windows.Forms.Button btn_ConfirmLink;
		private System.Windows.Forms.Button btn_CancelLink;
		public System.Windows.Forms.TextBox txt_LinkLocation;
		public System.Windows.Forms.TextBox txt_LinkArgs;
		public System.Windows.Forms.TextBox txt_LinkIcon;
		public System.Windows.Forms.TextBox txt_LinkName;
		private System.Windows.Forms.Label lbl_LinkName;
	}
}