using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TC.BaseConverter
{
	class BaseConverterTextBox : TextBox
	{
		Base fBase;
		public Base Base
		{
			get { return fBase; }
			set 
			{
				if (fBase != value)
				{
					fBase = value;
					UpdateDisplay();
				}
			}
		}

		BaseFormatter Formatter
		{
			get
			{
				switch (fBase)
				{
					case Base.Binary: return BaseFormatter.BinaryFormatter;
					case Base.Octal: return BaseFormatter.OctalFormatter;
					case Base.Decimal: return BaseFormatter.DecimalFormatter;
					case Base.Hexadecimal: return BaseFormatter.HexadecimalFormatter;
					default: return null;
				}
			}
		}

		BaseParser Parser
		{
			get
			{
				switch (fBase)
				{
					case Base.Binary: return BaseParser.BinaryParser;
					case Base.Octal: return BaseParser.OctalParser;
					case Base.Decimal: return BaseParser.DecimalParser;
					case Base.Hexadecimal: return BaseParser.HexadecimalParser;
					default: return null;
				}
			}
		}

		bool fGroupDigits;
		public bool GroupDigits
		{
			get { return fGroupDigits; }
			set
			{
				if (fGroupDigits != value)
				{
					fGroupDigits = value;
					UpdateDisplay();
				}
			}
		}

		ulong? fCurrentValue;
		public ulong? CurrentValue
		{
			get { return fCurrentValue; }
			set
			{
				if (fCurrentValue != value)
				{
					fCurrentValue = value;
					UpdateDisplay();
				}
			}
		}

		bool fUpdating;
		void UpdateDisplay()
		{
			if (fUpdating) return;

			int lStart = Text.Length - SelectionStart;

			fUpdating = true;
			BaseFormatter lFormatter = Formatter;
			Text = (lFormatter != null ? lFormatter.Format(fCurrentValue, fGroupDigits) : "");
			fUpdating = false;
			
			if (lStart >= 0 && lStart < Text.Length)
				SelectionStart = Text.Length - lStart;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			BaseParser lParser = Parser;
			fCurrentValue = (lParser != null ? lParser.Parse(Text) : null);
			UpdateDisplay();

			base.OnTextChanged(e);
		}
	}
}
