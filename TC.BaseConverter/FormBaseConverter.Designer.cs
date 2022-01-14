namespace TC.BaseConverter
{
	partial class FormBaseConverter
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
			System.Windows.Forms.MenuStrip lMenuStrip;
			System.Windows.Forms.ToolStripMenuItem lMenuItemBaseConverter;
			System.Windows.Forms.ToolStripMenuItem lMenuItemStyle;
			System.Windows.Forms.ToolStripSeparator lSeparator2;
			System.Windows.Forms.ToolStripMenuItem lMenuItemInfo;
			System.Windows.Forms.ToolStripSeparator lSeparator1;
			System.Windows.Forms.ToolStripMenuItem lMenuItemClose;
			System.Windows.Forms.TableLayoutPanel lPanelTableLayout;
			ComponentFactory.Krypton.Toolkit.KryptonLabel lLabelBinary;
			ComponentFactory.Krypton.Toolkit.KryptonLabel lLabelOctal;
			ComponentFactory.Krypton.Toolkit.KryptonLabel lLabelDecimal;
			ComponentFactory.Krypton.Toolkit.KryptonLabel lLabelHexadecimal;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseConverter));
			this.fMenuItemApplyChrome = new System.Windows.Forms.ToolStripMenuItem();
			this.fMenuItemColorSilver = new System.Windows.Forms.ToolStripMenuItem();
			this.fMenuItemColorBlack = new System.Windows.Forms.ToolStripMenuItem();
			this.fMenuItemColorBlue = new System.Windows.Forms.ToolStripMenuItem();
			this.fMenuItemGroupDigits = new System.Windows.Forms.ToolStripMenuItem();
			this.fTextBoxBinary = new TC.BaseConverter.BaseConverterTextBox();
			this.fTextBoxOctal = new TC.BaseConverter.BaseConverterTextBox();
			this.fTextBoxDecimal = new TC.BaseConverter.BaseConverterTextBox();
			this.fTextBoxHexadecimal = new TC.BaseConverter.BaseConverterTextBox();
			this.fKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
			lMenuStrip = new System.Windows.Forms.MenuStrip();
			lMenuItemBaseConverter = new System.Windows.Forms.ToolStripMenuItem();
			lMenuItemStyle = new System.Windows.Forms.ToolStripMenuItem();
			lSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			lMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
			lSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			lMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			lPanelTableLayout = new System.Windows.Forms.TableLayoutPanel();
			lLabelBinary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			lLabelOctal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			lLabelDecimal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			lLabelHexadecimal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			lMenuStrip.SuspendLayout();
			lPanelTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(lLabelBinary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lLabelOctal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lLabelDecimal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lLabelHexadecimal)).BeginInit();
			this.SuspendLayout();
			// 
			// lMenuStrip
			// 
			lMenuStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			lMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lMenuItemBaseConverter});
			lMenuStrip.Location = new System.Drawing.Point(0, 0);
			lMenuStrip.Name = "lMenuStrip";
			lMenuStrip.Size = new System.Drawing.Size(576, 24);
			lMenuStrip.TabIndex = 0;
			// 
			// lMenuItemBaseConverter
			// 
			lMenuItemBaseConverter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lMenuItemStyle,
            this.fMenuItemGroupDigits,
            lMenuItemInfo,
            lSeparator1,
            lMenuItemClose});
			lMenuItemBaseConverter.Name = "lMenuItemBaseConverter";
			lMenuItemBaseConverter.Size = new System.Drawing.Size(96, 20);
			lMenuItemBaseConverter.Text = "&Base Converter";
			// 
			// lMenuItemStyle
			// 
			lMenuItemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fMenuItemApplyChrome,
            lSeparator2,
            this.fMenuItemColorSilver,
            this.fMenuItemColorBlack,
            this.fMenuItemColorBlue});
			lMenuItemStyle.Name = "lMenuItemStyle";
			lMenuItemStyle.Size = new System.Drawing.Size(152, 22);
			lMenuItemStyle.Text = "&Style";
			// 
			// fMenuItemApplyChrome
			// 
			this.fMenuItemApplyChrome.Checked = true;
			this.fMenuItemApplyChrome.CheckOnClick = true;
			this.fMenuItemApplyChrome.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fMenuItemApplyChrome.Name = "fMenuItemApplyChrome";
			this.fMenuItemApplyChrome.Size = new System.Drawing.Size(151, 22);
			this.fMenuItemApplyChrome.Text = "&Apply chrome";
			this.fMenuItemApplyChrome.Click += new System.EventHandler(this.HandlerMenuItemApplyChromeClick);
			// 
			// lSeparator2
			// 
			lSeparator2.Name = "lSeparator2";
			lSeparator2.Size = new System.Drawing.Size(148, 6);
			// 
			// fMenuItemColorSilver
			// 
			this.fMenuItemColorSilver.Checked = true;
			this.fMenuItemColorSilver.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fMenuItemColorSilver.Name = "fMenuItemColorSilver";
			this.fMenuItemColorSilver.Size = new System.Drawing.Size(151, 22);
			this.fMenuItemColorSilver.Text = "&Silver";
			this.fMenuItemColorSilver.Click += new System.EventHandler(this.HandlerMenuItemColorClick);
			// 
			// fMenuItemColorBlack
			// 
			this.fMenuItemColorBlack.Name = "fMenuItemColorBlack";
			this.fMenuItemColorBlack.Size = new System.Drawing.Size(151, 22);
			this.fMenuItemColorBlack.Text = "&Black";
			this.fMenuItemColorBlack.Click += new System.EventHandler(this.HandlerMenuItemColorClick);
			// 
			// fMenuItemColorBlue
			// 
			this.fMenuItemColorBlue.Name = "fMenuItemColorBlue";
			this.fMenuItemColorBlue.Size = new System.Drawing.Size(151, 22);
			this.fMenuItemColorBlue.Text = "Bl&ue";
			this.fMenuItemColorBlue.Click += new System.EventHandler(this.HandlerMenuItemColorClick);
			// 
			// fMenuItemGroupDigits
			// 
			this.fMenuItemGroupDigits.Checked = true;
			this.fMenuItemGroupDigits.CheckOnClick = true;
			this.fMenuItemGroupDigits.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fMenuItemGroupDigits.Name = "fMenuItemGroupDigits";
			this.fMenuItemGroupDigits.Size = new System.Drawing.Size(152, 22);
			this.fMenuItemGroupDigits.Text = "&Group digits";
			this.fMenuItemGroupDigits.Click += new System.EventHandler(this.HandlerMenuItemGroupDigitsClick);
			// 
			// lMenuItemInfo
			// 
			lMenuItemInfo.Name = "lMenuItemInfo";
			lMenuItemInfo.ShortcutKeys = System.Windows.Forms.Keys.F1;
			lMenuItemInfo.Size = new System.Drawing.Size(152, 22);
			lMenuItemInfo.Text = "&Info...";
			lMenuItemInfo.Click += new System.EventHandler(this.HandlerMenuItemInfoClick);
			// 
			// lSeparator1
			// 
			lSeparator1.Name = "lSeparator1";
			lSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// lMenuItemClose
			// 
			lMenuItemClose.Name = "lMenuItemClose";
			lMenuItemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			lMenuItemClose.Size = new System.Drawing.Size(152, 22);
			lMenuItemClose.Text = "&Close";
			lMenuItemClose.Click += new System.EventHandler(this.HandlerMenuItemCloseClick);
			// 
			// lPanelTableLayout
			// 
			lPanelTableLayout.AutoSize = true;
			lPanelTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			lPanelTableLayout.ColumnCount = 2;
			lPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			lPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			lPanelTableLayout.Controls.Add(this.fTextBoxBinary, 0, 0);
			lPanelTableLayout.Controls.Add(this.fTextBoxOctal, 0, 1);
			lPanelTableLayout.Controls.Add(this.fTextBoxDecimal, 0, 2);
			lPanelTableLayout.Controls.Add(this.fTextBoxHexadecimal, 0, 3);
			lPanelTableLayout.Controls.Add(lLabelBinary, 1, 0);
			lPanelTableLayout.Controls.Add(lLabelOctal, 1, 1);
			lPanelTableLayout.Controls.Add(lLabelDecimal, 1, 2);
			lPanelTableLayout.Controls.Add(lLabelHexadecimal, 1, 3);
			lPanelTableLayout.Location = new System.Drawing.Point(0, 27);
			lPanelTableLayout.Name = "lPanelTableLayout";
			lPanelTableLayout.RowCount = 4;
			lPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			lPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			lPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			lPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			lPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			lPanelTableLayout.Size = new System.Drawing.Size(575, 108);
			lPanelTableLayout.TabIndex = 1;
			// 
			// fTextBoxBinary
			// 
			this.fTextBoxBinary.Base = TC.BaseConverter.Base.Binary;
			this.fTextBoxBinary.CurrentValue = ((ulong)(0ul));
			this.fTextBoxBinary.GroupDigits = true;
			this.fTextBoxBinary.Location = new System.Drawing.Point(3, 3);
			this.fTextBoxBinary.Name = "fTextBoxBinary";
			this.fTextBoxBinary.Size = new System.Drawing.Size(467, 21);
			this.fTextBoxBinary.TabIndex = 0;
			this.fTextBoxBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fTextBoxBinary.TextChanged += new System.EventHandler(this.HandlerTextBoxTextChanged);
			// 
			// fTextBoxOctal
			// 
			this.fTextBoxOctal.Base = TC.BaseConverter.Base.Octal;
			this.fTextBoxOctal.CurrentValue = null;
			this.fTextBoxOctal.GroupDigits = true;
			this.fTextBoxOctal.Location = new System.Drawing.Point(3, 30);
			this.fTextBoxOctal.Name = "fTextBoxOctal";
			this.fTextBoxOctal.Size = new System.Drawing.Size(467, 21);
			this.fTextBoxOctal.TabIndex = 2;
			this.fTextBoxOctal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fTextBoxOctal.TextChanged += new System.EventHandler(this.HandlerTextBoxTextChanged);
			// 
			// fTextBoxDecimal
			// 
			this.fTextBoxDecimal.Base = TC.BaseConverter.Base.Decimal;
			this.fTextBoxDecimal.CurrentValue = null;
			this.fTextBoxDecimal.GroupDigits = true;
			this.fTextBoxDecimal.Location = new System.Drawing.Point(3, 57);
			this.fTextBoxDecimal.Name = "fTextBoxDecimal";
			this.fTextBoxDecimal.Size = new System.Drawing.Size(467, 21);
			this.fTextBoxDecimal.TabIndex = 4;
			this.fTextBoxDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fTextBoxDecimal.TextChanged += new System.EventHandler(this.HandlerTextBoxTextChanged);
			// 
			// fTextBoxHexadecimal
			// 
			this.fTextBoxHexadecimal.Base = TC.BaseConverter.Base.Hexadecimal;
			this.fTextBoxHexadecimal.CurrentValue = null;
			this.fTextBoxHexadecimal.GroupDigits = true;
			this.fTextBoxHexadecimal.Location = new System.Drawing.Point(3, 84);
			this.fTextBoxHexadecimal.Name = "fTextBoxHexadecimal";
			this.fTextBoxHexadecimal.Size = new System.Drawing.Size(467, 21);
			this.fTextBoxHexadecimal.TabIndex = 6;
			this.fTextBoxHexadecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fTextBoxHexadecimal.TextChanged += new System.EventHandler(this.HandlerTextBoxTextChanged);
			// 
			// lLabelBinary
			// 
			lLabelBinary.Location = new System.Drawing.Point(476, 3);
			lLabelBinary.Name = "lLabelBinary";
			lLabelBinary.Size = new System.Drawing.Size(57, 19);
			lLabelBinary.TabIndex = 1;
			lLabelBinary.Values.Text = "Binary (2)";
			// 
			// lLabelOctal
			// 
			lLabelOctal.Location = new System.Drawing.Point(476, 30);
			lLabelOctal.Name = "lLabelOctal";
			lLabelOctal.Size = new System.Drawing.Size(52, 19);
			lLabelOctal.TabIndex = 3;
			lLabelOctal.Values.Text = "Octal (8)";
			// 
			// lLabelDecimal
			// 
			lLabelDecimal.Location = new System.Drawing.Point(476, 57);
			lLabelDecimal.Name = "lLabelDecimal";
			lLabelDecimal.Size = new System.Drawing.Size(72, 19);
			lLabelDecimal.TabIndex = 5;
			lLabelDecimal.Values.Text = "Decimal (10)";
			// 
			// lLabelHexadecimal
			// 
			lLabelHexadecimal.Location = new System.Drawing.Point(476, 84);
			lLabelHexadecimal.Name = "lLabelHexadecimal";
			lLabelHexadecimal.Size = new System.Drawing.Size(96, 19);
			lLabelHexadecimal.TabIndex = 7;
			lLabelHexadecimal.Values.Text = "Hexadecimal (16)";
			// 
			// fKryptonManager
			// 
			this.fKryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver;
			// 
			// FormBaseConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(576, 139);
			this.Controls.Add(lPanelTableLayout);
			this.Controls.Add(lMenuStrip);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = lMenuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBaseConverter";
			this.Text = "Base Converter";
			lMenuStrip.ResumeLayout(false);
			lMenuStrip.PerformLayout();
			lPanelTableLayout.ResumeLayout(false);
			lPanelTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(lLabelBinary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lLabelOctal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lLabelDecimal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lLabelHexadecimal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonManager fKryptonManager;
		private System.Windows.Forms.ToolStripMenuItem fMenuItemColorSilver;
		private System.Windows.Forms.ToolStripMenuItem fMenuItemColorBlack;
		private System.Windows.Forms.ToolStripMenuItem fMenuItemColorBlue;
		private BaseConverterTextBox fTextBoxBinary;
		private BaseConverterTextBox fTextBoxOctal;
		private BaseConverterTextBox fTextBoxDecimal;
		private BaseConverterTextBox fTextBoxHexadecimal;
		private System.Windows.Forms.ToolStripMenuItem fMenuItemApplyChrome;
		private System.Windows.Forms.ToolStripMenuItem fMenuItemGroupDigits;

	}
}

