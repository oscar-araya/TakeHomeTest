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

        public List<TokensDTO> Parse(string input)
        {
            List<TokensDTO> tokens = new List<TokensDTO>();

            List<string> lines = GetLines(input.Trim());

            lines.ForEach(line => tokens.Add(ParseLine(line.Trim())));

            return tokens;
        }

        private List<string> GetLines(string input)
        {
            return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private TokensDTO ParseLine(string line)
        {
            TokensDTO lineTokens = new TokensDTO();

            lineTokens.Tokens = line.Split(DELIMITERS, StringSplitOptions.RemoveEmptyEntries).ToList();

            return lineTokens;
        }
    }
}

