using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TC.BaseConverter
{
	[RunInstaller(true)]
	public class CalctorInstaller : Installer
	{
		[DllImport("mscoree.dll")]
		static extern int GetCORSystemDirectory([MarshalAs(UnmanagedType.LPWStr)]StringBuilder buffer, int bufferLength, out int length);

		public override void Install(System.Collections.IDictionary stateSaver)
		{
			base.Install(stateSaver);

			string lPathSelf = GetType().Assembly.Location;

			StringBuilder lPathSystem = new StringBuilder(1024);
			int lSize;
			GetCORSystemDirectory(lPathSystem, lPathSystem.Capacity, out lSize);

			try
			{
				ProcessStartInfo lInfo = new ProcessStartInfo(lPathSystem.ToString() + "ngen.exe", "\"" + lPathSelf + "\"");
				lInfo.WindowStyle = ProcessWindowStyle.Hidden;

				Process.Start(lInfo).WaitForExit();
			}
			catch (Exception lException)
			{
				throw new InstallException(lException.Message);
			}
		}
	}
}