using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Z_Link
{
	public partial class Selector : Form
	{
		public Selector()
		{
			InitializeComponent();

			pic_WindowClose.Image = Bitmaps.Instance[12, Color.Black, Color.White, BitmapType.Close];
			pic_WindowMin.Image = Bitmaps.Instance[12, Color.Black, Color.White, BitmapType.Minimize];
			pic_AddLink.Image = new Bitmap(23, 23);
			pic_RemoveLink.Image = new Bitmap(23, 23);

			using (Graphics gfx_AddLink = Graphics.FromImage(pic_AddLink.Image))
			{
				gfx_AddLink.DrawLine(new Pen(Color.Black),
					new Point(11, 6), new Point(11, 16));
				gfx_AddLink.DrawLine(new Pen(Color.Black),
					new Point(6, 11), new Point(16, 11));
			}
			using (Graphics gfx_RemoveLink = Graphics.FromImage(pic_RemoveLink.Image))
				gfx_RemoveLink.DrawLine(new Pen(Color.Black),
					new Point(6, 11), new Point(16, 11));

			lst_ZLinks.LargeImageList = new ImageList();
			lst_ZLinks.SmallImageList = new ImageList();

			string[] arr_ProgArgs = Environment.GetCommandLineArgs().Where((elm, index) => index > 0).ToArray();
			if (arr_ProgArgs.Length > 0 && Path.GetExtension(arr_ProgArgs[0]) == ".zlnk")
			{
				ZLink zlnk_ArgLink = ZLink.FromFile(arr_ProgArgs[0]);
				JObject jobj_ArgLink = zlnk_ArgLink.ToJSON();

				if (File.Exists($"{Application.StartupPath}\\zconf.json"))
				{
					int matchLinks = 0;

					JArray jarr_ZLinks = JArray.Parse(File.ReadAllText($"{Application.StartupPath}\\zconf.json"));
					foreach (JObject jobj_ZLink in jarr_ZLinks)
						if (jobj_ZLink.Value<string>("location") == jobj_ArgLink.Value<string>("location") &&
							jobj_ZLink.Value<string>("name") == jobj_ArgLink.Value<string>("name") &&
							jobj_ZLink.Value<string>("arguments") == jobj_ArgLink.Value<string>("arguments") &&
							jobj_ZLink.Value<string>("icon") == jobj_ArgLink.Value<string>("icon"))
							matchLinks++;
					if (matchLinks == 0)
						jarr_ZLinks.Add(jobj_ArgLink);

					File.WriteAllText($"{Application.StartupPath}\\zconf.json", jarr_ZLinks.ToString().Replace("  ", "\t\t"));
				}
				else File.WriteAllText($"{Application.StartupPath}\\zconf.json", "[\n" + jobj_ArgLink.ToString().Replace("  ", "\t\t") + "\n]");

				Process.Start(zlnk_ArgLink.Location, zlnk_ArgLink.Arguments);
				Timer t = new Timer { Interval = 100 };
				t.Tick += (s, e) =>
				{
					t.Enabled = false;
					WindowClose_Click(s, e);
				};
				t.Start();
			}

			if (File.Exists($"{Application.StartupPath}\\zconf.json") && (arr_ProgArgs.Length == 0 || Path.GetExtension(arr_ProgArgs[0]) != ".zlnk"))
			{
				JArray jarr_ZLinks = JArray.Parse(File.ReadAllText($"{Application.StartupPath}\\zconf.json"));
				foreach (JObject jobj_ZLink in jarr_ZLinks)
				{
					string str_Location = jobj_ZLink.Value<string>("location");
					string str_Name = jobj_ZLink.Value<string>("name");
					string str_Arguments = jobj_ZLink.Value<string>("args");
					string str_Icon = jobj_ZLink.Value<string>("icon");

					dict_ZLinks.Add(str_Name, ZLink.FromParams(str_Location, str_Name, str_Arguments, str_Icon));


					ListViewItem vwitm_ListItem = new ListViewItem();
					vwitm_ListItem.Text = str_Name;
					vwitm_ListItem.ImageIndex = jarr_ZLinks.IndexOf(jobj_ZLink);
					lst_ZLinks.LargeImageList.Images.Add((Bitmap)Image.FromFile(str_Icon));
					lst_ZLinks.SmallImageList.Images.Add((Bitmap)Image.FromFile(str_Icon));
					lst_ZLinks.Items.Add(vwitm_ListItem);
				}
			}
		}

		private Dictionary<string, ZLink> dict_ZLinks = new Dictionary<string, ZLink>();
		private bool bl_RemoveLink = false;
		private bool bl_CreateLink = false;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.FillRectangle(Brushes.Silver, new Rectangle(0, 0, Width, Height));
			e.Graphics.FillRectangle(Brushes.White, new Rectangle(1, 1, Width - 2, Height - 2));
		}

		private void SelectorWindow_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) Win32.Drag(Handle);
		}

		private void SelectorControl_MouseEnter(object sender, EventArgs e)
		{
			((Control)sender).Cursor = Win32.GetHandCursor();

			if (sender == pic_RemoveLink)
				((Control)sender).BackColor = bl_RemoveLink ? Color.Red : Color.WhiteSmoke;
			else if (sender == pic_CreateLink)
				((Control)sender).BackColor = bl_CreateLink ? Color.SeaGreen : Color.WhiteSmoke;
			else ((Control)sender).BackColor = Color.WhiteSmoke;
		}

		private void SelectorControl_MouseLeave(object sender, EventArgs e)
		{
			if (sender == pic_RemoveLink)
				((Control)sender).BackColor = bl_RemoveLink ? Color.Red : Color.White;
			else if (sender == pic_CreateLink)
				((Control)sender).BackColor = bl_CreateLink ? Color.SeaGreen : Color.White;
			else ((Control)sender).BackColor = Color.White;
		}

		private void WindowClose_Click(object sender, EventArgs e)
		{
			icn_TrayIcon.Visible = false;
			Application.Exit();
		}

		private void WindowMin_Click(object sender, EventArgs e)
		{
			Visible = false;
			icn_TrayIcon.Visible = true;
		}

		private void TrayIcon_Click(object sender, EventArgs e)
		{
			Visible = true;
			icn_TrayIcon.Visible = false;
		}

		private void ProgramDir_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", Application.StartupPath);
		}

		private void ZLinks_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lst_ZLinks.SelectedItems.Count == 1)
			{
				if (bl_RemoveLink)
				{
					JArray jarr_ZLinks = JArray.Parse(File.ReadAllText($"{Application.StartupPath}\\zconf.json"));
					dict_ZLinks.Remove(lst_ZLinks.SelectedItems[0].Text);
					jarr_ZLinks.RemoveAt(lst_ZLinks.SelectedIndices[0]);
					File.WriteAllText($"{Application.StartupPath}\\zconf.json", jarr_ZLinks.ToString().Replace("  ", "\t\t"));

					lst_ZLinks.Items.RemoveAt(lst_ZLinks.SelectedIndices[0]);
				}
				else if (bl_CreateLink)
				{
					using (SaveFileDialog sfd = new SaveFileDialog
					{
						Title = "Where do you want to create the link?",
						Filter = "Z-Link|*.zlnk"
					}) if (sfd.ShowDialog() == DialogResult.OK)
						{
							ZLink zlnk_SelectedLink = dict_ZLinks[lst_ZLinks.SelectedItems[0].Text];
							File.WriteAllText(sfd.FileName, string.Format("loc~[{0}]\nname~[{1}]\narg~[{2}]\nicon~[{3}]",
								zlnk_SelectedLink.Location, zlnk_SelectedLink.Name, zlnk_SelectedLink.Arguments, zlnk_SelectedLink.ToJSON().Value<string>("icon")));
						}
				}
				else
				{
					string str_Location = dict_ZLinks[lst_ZLinks.SelectedItems[0].Text].Location;
					string str_Arguments = dict_ZLinks[lst_ZLinks.SelectedItems[0].Text].Arguments;

					Process.Start(str_Location, str_Arguments);
				}
			}
		}

		private void AddLink_Click(object sender, EventArgs e)
		{
			using (AddLink al = new AddLink())
				if (al.ShowDialog() == DialogResult.OK)
				{
					ZLink zlnk_NewLink = ZLink.FromParams(al.txt_LinkLocation.Text, al.txt_LinkName.Text, al.txt_LinkArgs.Text, al.txt_LinkIcon.Text);
					JObject jobj_NewLink = zlnk_NewLink.ToJSON();
					if (File.Exists($"{Application.StartupPath}\\zconf.json"))
					{
						int matchLinks = 0;

						JArray jarr_ZLinks = JArray.Parse(File.ReadAllText($"{Application.StartupPath}\\zconf.json"));
						foreach (JObject jobj_ZLink in jarr_ZLinks)
							if (jobj_ZLink.Value<string>("location") == jobj_NewLink.Value<string>("location") &&
								jobj_ZLink.Value<string>("name") == jobj_NewLink.Value<string>("name") &&
								jobj_ZLink.Value<string>("arguments") == jobj_NewLink.Value<string>("arguments") &&
								jobj_ZLink.Value<string>("icon") == jobj_NewLink.Value<string>("icon"))
								matchLinks++;
						if (matchLinks == 0)
							jarr_ZLinks.Add(jobj_NewLink);

						File.WriteAllText($"{Application.StartupPath}\\zconf.json", jarr_ZLinks.ToString().Replace("  ", "\t\t"));
					}
					dict_ZLinks.Add(zlnk_NewLink.Name, zlnk_NewLink);

					ListViewItem vwitm_ListItem = new ListViewItem();
					vwitm_ListItem.Text = zlnk_NewLink.Name;
					vwitm_ListItem.ImageIndex = dict_ZLinks.Count;
					lst_ZLinks.LargeImageList.Images.Add((Bitmap)Image.FromFile(al.txt_LinkIcon.Text));
					lst_ZLinks.SmallImageList.Images.Add((Bitmap)Image.FromFile(al.txt_LinkIcon.Text));
					lst_ZLinks.Items.Add(vwitm_ListItem);
				}
		}

		private void RemoveLink_Click(object sender, EventArgs e)
		{
			bl_RemoveLink = !bl_RemoveLink;
			((Control)sender).BackColor = bl_RemoveLink ? Color.Red : Color.WhiteSmoke;

			if (bl_RemoveLink)
			{
				bl_CreateLink = false;
				pic_CreateLink.BackColor = Color.White;
			}
		}

		private void CreateLink_Click(object sender, EventArgs e)
		{
			bl_CreateLink = !bl_CreateLink;
			((Control)sender).BackColor = bl_CreateLink ? Color.SeaGreen : Color.WhiteSmoke;

			if (bl_CreateLink)
			{
				bl_RemoveLink = false;
				pic_RemoveLink.BackColor = Color.White;
			}
		}
	}
}
