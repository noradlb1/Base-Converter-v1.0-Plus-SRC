using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using TC.BaseConverter.Properties;

namespace TC.BaseConverter
{
	public partial class FormBaseConverter : KryptonForm
	{
		Settings fSettings;

		public FormBaseConverter()
		{
			InitializeComponent();
			fSettings = new Settings();
			fSettings.Reload();
			ReadSettings();
		}

		void ReadSettings()
		{
			if (!fSettings.FormLocation.IsEmpty)
			{
				StartPosition = FormStartPosition.Manual;
				Location = fSettings.FormLocation;
			}

			switch (fSettings.ColorScheme)
			{
				case "Black":
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
					fMenuItemColorBlack.Checked = true;
					fMenuItemColorBlue.Checked = false;
					fMenuItemColorSilver.Checked = false;
					break;
				case "Blue":
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
					fMenuItemColorBlack.Checked = false;
					fMenuItemColorBlue.Checked = true;
					fMenuItemColorSilver.Checked = false;
					break;
				default:
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
					fMenuItemColorBlack.Checked = false;
					fMenuItemColorBlue.Checked = false;
					fMenuItemColorSilver.Checked = true; 
					break;
			}
			
			fMenuItemApplyChrome.Checked = AllowFormChrome = fSettings.ApplyChrome;
			fMenuItemGroupDigits.Checked = fSettings.GroupDigits;
			UpdateTextBoxesGroupDigits();
		}

		protected override void OnMove(EventArgs e)
		{
			base.OnMove(e);
			if (fSettings != null && WindowState == FormWindowState.Normal)
				fSettings.FormLocation = Location;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			fSettings.Save();
		}

		private void HandlerMenuItemCloseClick(object sender, EventArgs e)
		{
			Close();
		}

		void SetColorScheme(string colorScheme)
		{
			fSettings.ColorScheme = colorScheme;
			switch (colorScheme)
			{
				case "Black":
					fMenuItemColorBlack.Checked = true;
					fMenuItemColorBlue.Checked = false;
					fMenuItemColorSilver.Checked = false;
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
					break;
				case "Blue":
					fMenuItemColorBlack.Checked = false;
					fMenuItemColorBlue.Checked = true;
					fMenuItemColorSilver.Checked = false;
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
					break;
				default:
					fMenuItemColorBlack.Checked = false;
					fMenuItemColorBlue.Checked = false;
					fMenuItemColorSilver.Checked = true;
					fKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
					break;
			}
		}

		private void HandlerMenuItemColorClick(object sender, EventArgs e)
		{
			if (sender == fMenuItemColorBlack) SetColorScheme("Black");
			else if (sender == fMenuItemColorBlue) SetColorScheme("Blue");
			else SetColorScheme("Silver");
		}

		private void HandlerMenuItemApplyChromeClick(object sender, EventArgs e)
		{
			fSettings.ApplyChrome = AllowFormChrome = fMenuItemApplyChrome.Checked;
		}

		private void HandlerMenuItemGroupDigitsClick(object sender, EventArgs e)
		{
			fSettings.GroupDigits = fMenuItemGroupDigits.Checked;
			UpdateTextBoxesGroupDigits();
		}

		void UpdateTextBoxesGroupDigits()
		{
			fTextBoxBinary.GroupDigits = fSettings.GroupDigits;
			fTextBoxOctal.GroupDigits = fSettings.GroupDigits;
			fTextBoxDecimal.GroupDigits = fSettings.GroupDigits;
			fTextBoxHexadecimal.GroupDigits = fSettings.GroupDigits;
		}

		private void HandlerTextBoxTextChanged(object sender, EventArgs e)
		{
			BaseConverterTextBox lTextBox = sender as BaseConverterTextBox;
			if (lTextBox != null)
			{
				ulong? lCurrentValue = lTextBox.CurrentValue;
				fTextBoxBinary.CurrentValue = lCurrentValue;
				fTextBoxOctal.CurrentValue = lCurrentValue;
				fTextBoxDecimal.CurrentValue = lCurrentValue;
				fTextBoxHexadecimal.CurrentValue = lCurrentValue;
			}
		}

		private void HandlerMenuItemInfoClick(object sender, EventArgs e)
		{
			using (FormInfo lDialog = new FormInfo())
			{
				lDialog.AllowFormChrome = fSettings.ApplyChrome;
				lDialog.ShowDialog(this);
			}
		}
	}
}