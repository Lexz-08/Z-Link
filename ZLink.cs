using Newtonsoft.Json.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Z_Link
{
	internal class ZLink
	{
		private string str_LinkLocation = string.Empty;
		private string str_LinkName = string.Empty;
		private string str_LinkArguments = string.Empty;
		private string str_LinkIcon = string.Empty;
		private Bitmap bmp_LinkIcon = null;

		/// <summary>
		/// File location of the z-link
		/// </summary>
		public string Location => str_LinkLocation;

		/// <summary>
		/// Name of the z-link
		/// </summary>
		public string Name => str_LinkName;

		/// <summary>
		/// Arguments to be passed during launch of z-linked file
		/// </summary>
		public string Arguments => str_LinkArguments;

		/// <summary>
		/// The icon of the z-link displayed on the selector window
		/// </summary>
		public Bitmap Icon => bmp_LinkIcon;

		public ZLink(string LinkLocation, string LinkName, string LinkArguments, string LinkIcon)
		{
			str_LinkLocation = LinkLocation;
			str_LinkName = LinkName;
			str_LinkArguments = LinkArguments;
			str_LinkIcon = LinkIcon;
			bmp_LinkIcon = (Bitmap)Image.FromFile(LinkIcon);
		}

		public static ZLink FromText(string Content)
		{
			string[] arr_File = Content.Split('\n');

			string str_Location = arr_File.Where(part => part.StartsWith("loc")).ToArray()[0]
				.Split('~').Where(part => part.StartsWith("["))
				.Select(line => line.Substring(line.IndexOf('[') + 1, line.LastIndexOf(']') - 1)).ToArray()[0];
			string str_Name = arr_File.Where(part => part.StartsWith("name")).ToArray()[0]
				.Split('~').Where(part => part.StartsWith("["))
				.Select(line => line.Substring(line.IndexOf('[') + 1, line.LastIndexOf(']') - 1)).ToArray()[0];
			string str_Argument = arr_File.Where(part => part.StartsWith("arg")).ToArray()[0]
				.Split('~').Where(part => part.StartsWith("["))
				.Select(line => line.Substring(line.IndexOf('[') + 1, line.LastIndexOf(']') - 1)).ToArray()[0];
			string str_Icon = arr_File.Where(part => part.StartsWith("icon")).ToArray()[0]
				.Split('~').Where(part => part.StartsWith("["))
				.Select(line => line.Substring(line.IndexOf('[') + 1, line.LastIndexOf(']') - 1)).ToArray()[0];

			return new ZLink(str_Location, str_Name, str_Argument, str_Icon);
		}

		public static ZLink FromFile(string LinkFile)
		{
			if (!(Path.GetExtension(LinkFile) == ".zlnk"))
			{
				MessageBox.Show($"File type \"{Path.GetExtension(LinkFile)}\" not supported. Please use \".zlnk\" for links.", "Unsupported Extension",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			return FromText(File.ReadAllText(LinkFile));
		}

		public static ZLink FromParams(string LinkLocation, string LinkName, string LinkArguments, string LinkIcon)
		{
			return new ZLink(LinkLocation, LinkName, LinkArguments, LinkIcon);
		}

		public JObject ToJSON()
		{
			JObject jobj_ZLink = new JObject();
			jobj_ZLink.Add("location", str_LinkLocation);
			jobj_ZLink.Add("name", str_LinkName);
			jobj_ZLink.Add("args", str_LinkArguments);
			jobj_ZLink.Add("icon", str_LinkIcon);

			return jobj_ZLink;
		}
	}
}
