using System;
using System.Collections.Generic;
using System.Text;

namespace TC.BaseConverter
{
	class BaseParser
	{
		const string Digits = "0123456789ABCDEF";
		readonly ulong fBase;

		public BaseParser(int numberBase)
		{
			fBase = (ulong)numberBase;
		}

		public ulong? Parse(string input)
		{
			if (input == null) throw new ArgumentNullException("input");
			input = input.Trim().ToUpper();

			ulong lResult = 0;
			foreach (char lChar in input)
				if (IsDigit(lChar))
				{
					ulong lDigit = GetDigit(lChar);
					if (lResult <= (ulong.MaxValue - lDigit) / fBase)
						lResult = lResult * fBase + lDigit;
					else return lResult;
				}
			return lResult;
		}

		bool IsDigit(char c) 
		{
			ulong lDigit = (ulong)Digits.IndexOf(c);
			return lDigit >= 0 && lDigit < fBase;
		}

		ulong GetDigit(char c) { return (ulong)Digits.IndexOf(c); }

		public static readonly BaseParser
			BinaryParser = new BaseParser(2),
			OctalParser = new BaseParser(8),
			DecimalParser = new BaseParser(10),
			HexadecimalParser = new BaseParser(16);
	}
}
