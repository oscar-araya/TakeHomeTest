// *************************************
// BoxBracketFormatter
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
using BusinessLogic.DTO;

namespace BusinessLogic.Formatter
{
	public class BoxBracketFormatter : IFormatter
	{
		public BoxBracketFormatter()
		{
		}

        public string Format(List<LineTokens> tokens)
        {
            string formattedOutput = string.Empty;

            tokens.ForEach(lineToken => formattedOutput += FormatLine(lineToken) + Environment.NewLine);

            return formattedOutput;
        }

        private string FormatLine(LineTokens lineTokens)
        {
            string line = string.Empty;

            lineTokens.Tokens.ForEach(token => line += $"[{token}] ");

            return line.Trim();
        }
    }
}

