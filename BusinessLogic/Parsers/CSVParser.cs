// *************************************
// CSVParser
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
using BusinessLogic.DTO;

namespace BusinessLogic.Parsers
{
	public class CSVParser : IParser
	{
        readonly string[] DELIMITERS = { "\",\"", "\",", ",\"", "\"" };

        public CSVParser()
		{
		}

        public List<LineTokens> Parse(string input)
        {
            var linesTokens = new List<LineTokens>();

            var lines = GetLines(input.Trim());

            lines.ForEach(line => linesTokens.Add(ParseLine(line.Trim())));

            return linesTokens;
        }

        private List<string> GetLines(string input)
        {
            return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private LineTokens ParseLine(string line)
        {
            var lineTokens = new LineTokens();

            lineTokens.Tokens = line.Split(DELIMITERS, StringSplitOptions.RemoveEmptyEntries).ToList();

            return lineTokens;
        }
    }
}

