using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TC.BaseConverter
{
	class BaseFormatter
	{
		const string Digits = "0123456789ABCDEF";
		readonly ulong fBase;
		readonly int fGroupDigits;
		readonly string fGroupSeparator;

		public BaseFormatter(int numberBase, int groupDigits, string groupSeparator)
		{
			fBase = (ulong)numberBase;
			fGroupDigits = groupDigits;
			fGroupSeparator = groupSeparator;
		}

		public string Format(ulong? value, bool groupDigits)
		{
			if (!value.HasValue) return "";
			ulong lValue = value.Value;

			int lDigitCount = 0;
			StringBuilder lBuilder = new StringBuilder();
			while (lValue > 0)
			{
				int lDigit = (int)(lValue % fBase);
				if (groupDigits)
				{
					if (lDigitCount >= fGroupDigits)
					{
						lDigitCount = 0;
						lBuilder.Insert(0, fGroupSeparator);
					}
					lDigitCount += 1;
				}
				lBuilder.Insert(0, Digits[lDigit]);
				lValue /= fBase;
			}
			return lBuilder.ToString();
		}

		public static readonly BaseFormatter
			BinaryFormatter = new BaseFormatter(2, 4, NumberFormatInfo.CurrentInfo.NumberGroupSeparator),
			OctalFormatter = new BaseFormatter(8, 3, NumberFormatInfo.CurrentInfo.NumberGroupSeparator),
			DecimalFormatter = new BaseFormatter(10, 3, NumberFormatInfo.CurrentInfo.NumberGroupSeparator),
			HexadecimalFormatter = new BaseFormatter(16, 4, NumberFormatInfo.CurrentInfo.NumberGroupSeparator);
	}
}
