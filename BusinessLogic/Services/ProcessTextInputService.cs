// *************************************
// ParserService
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
using BusinessLogic.Formatter;
using BusinessLogic.Parsers;
using BusinessLogic.DTO;

namespace BusinessLogic.Services
{
	public class ProcessTextInput : IProcessInputService
	{
		private readonly IParser _parser;
		private readonly IFormatter _formatter;

        public ProcessTextInput(IParser parser, IFormatter formatter)
        {
            _parser = parser;
            _formatter = formatter;
        }

        public string ProcessInput(string input)
        {
            List<LineTokensDTO> tokens = _parser.Parse(input);

            return _formatter.Format(tokens);
        }
    }
}

