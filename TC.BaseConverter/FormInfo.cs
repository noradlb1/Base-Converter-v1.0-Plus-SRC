using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Diagnostics;

namespace TC.BaseConverter
{
	public partial class FormInfo : KryptonForm
	{
		public FormInfo()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			fLabelTitle.Values.ExtraText = "Version: " + ProductVersion;
			using (Stream lStream = GetType().Assembly.GetManifestResourceStream("TC.BaseConverter.Resources.License.rtf"))
				fRichTextBoxLicense.LoadFile(lStream, RichTextBoxStreamType.RichText);
			base.OnLoad(e);
		}

		private void HandlerLinkBlogLinkClicked(object sender, EventArgs e)
		{
			Process.Start("http://tommycarlier.blogspot.com/");
		}
	}
}