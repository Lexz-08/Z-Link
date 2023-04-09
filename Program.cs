using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Z_Link
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Registry.ClassesRoot.OpenSubKey(".zlnk\\shell\\open\\command", false) == null)
			{
				Registry.ClassesRoot.CreateSubKey(".zlnk").CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command").SetValue("", $"\"{Application.ExecutablePath}\" \"%1\"");
				Win32.UpdateIconAssociations();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Selector());
		}
	}
}
