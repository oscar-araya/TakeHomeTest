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

        public List<LineTokensDTO> Parse(string input)
        {
            List<LineTokensDTO> tokens = new List<LineTokensDTO>();

            List<string> lines = GetLines(input.Trim());

            lines.ForEach(line => tokens.Add(ParseLine(line.Trim())));

            return tokens;
        }

        private List<string> GetLines(string input)
        {
            return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private LineTokensDTO ParseLine(string line)
        {
            LineTokensDTO lineTokens = new LineTokensDTO();

            lineTokens.Tokens = line.Split(DELIMITERS, StringSplitOptions.RemoveEmptyEntries).ToList();

            return lineTokens;
        }
    }
}

