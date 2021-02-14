using System;
using System.Linq;
using System.Text;

namespace ReplaceWithAlphabetPosition
{
	class Program
	{
		private static char[] Alphabets = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		private const string text = "The sunset sets at twelve o' clock.";

		static void Main(string[] args)
		{
			var result = AlphabetPosition(text);
			Console.WriteLine(result);
		}

		public static string AlphabetPosition(string text)
		{
			var textAsCharArray = text.ToArray();

			var sb = new StringBuilder();
			for (var i = 0; i < textAsCharArray.Length; i++)
			{
				var numericIndex = Array.IndexOf(Alphabets, char.ToLowerInvariant(textAsCharArray[i]));
				//var numericIndex = 0;
				//var charValueFromText = textAsCharArray[i];
				//for (int k = 0; k < Alphabets.Length; k++)
				//{
				//	var charValueFromAlphabets = Alphabets[k];
				//	if (char.ToLowerInvariant(charValueFromText) == char.ToLowerInvariant(charValueFromAlphabets))
				//	{
				//		k++;
				//		numericIndex = k;
				//		sb.Append($"{numericIndex} ");
				//		break;
				//	}
				//}

				if (numericIndex != -1)
				{
					numericIndex++;
					sb.Append($"{numericIndex} ");
				}
			}
			
			var result = sb.ToString().TrimEnd();
			return result;
		}
	}
}
