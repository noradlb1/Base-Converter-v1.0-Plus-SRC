namespace TC.BaseConverter
{
	partial class FormInfo
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
			ComponentFactory.Krypton.Toolkit.KryptonButton lButtonClose;
			ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lLinkBlog;
			this.fLabelTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.fRichTextBoxLicense = new System.Windows.Forms.RichTextBox();
			lButtonClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			lLinkBlog = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
			((System.ComponentModel.ISupportInitialize)(lButtonClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lLinkBlog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fLabelTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// lButtonClose
			// 
			lButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			lButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			lButtonClose.Location = new System.Drawing.Point(256, 275);
			lButtonClose.Name = "lButtonClose";
			lButtonClose.Size = new System.Drawing.Size(90, 25);
			lButtonClose.TabIndex = 4;
			lButtonClose.Values.Text = "&Close";
			// 
			// lLinkBlog
			// 
			lLinkBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			lLinkBlog.Location = new System.Drawing.Point(12, 281);
			lLinkBlog.Name = "lLinkBlog";
			lLinkBlog.Size = new System.Drawing.Size(179, 19);
			lLinkBlog.TabIndex = 3;
			lLinkBlog.Values.Text = "http://tommycarlier.blogspot.com";
			lLinkBlog.LinkClicked += new System.EventHandler(this.HandlerLinkBlogLinkClicked);
			// 
			// fLabelTitle
			// 
			this.fLabelTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
			this.fLabelTitle.Location = new System.Drawing.Point(12, 12);
			this.fLabelTitle.Name = "fLabelTitle";
			this.fLabelTitle.Size = new System.Drawing.Size(225, 27);
			this.fLabelTitle.TabIndex = 0;
			this.fLabelTitle.Values.ExtraText = "Version: ?.?.?.?";
			this.fLabelTitle.Values.Text = "Base Converter";
			// 
			// fRichTextBoxLicense
			// 
			this.fRichTextBoxLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fRichTextBoxLicense.BackColor = System.Drawing.SystemColors.Window;
			this.fRichTextBoxLicense.Location = new System.Drawing.Point(12, 45);
			this.fRichTextBoxLicense.Name = "fRichTextBoxLicense";
			this.fRichTextBoxLicense.ReadOnly = true;
			this.fRichTextBoxLicense.Size = new System.Drawing.Size(334, 224);
			this.fRichTextBoxLicense.TabIndex = 2;
			this.fRichTextBoxLicense.Text = "";
			// 
			// FormInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 312);
			this.Controls.Add(this.fRichTextBoxLicense);
			this.Controls.Add(this.fLabelTitle);
			this.Controls.Add(lLinkBlog);
			this.Controls.Add(lButtonClose);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormInfo";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Info";
			((System.ComponentModel.ISupportInitialize)(lButtonClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lLinkBlog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fLabelTitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox fRichTextBoxLicense;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel fLabelTitle;
	}
}