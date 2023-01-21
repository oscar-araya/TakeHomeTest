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
using BusinessLogic.Validators;

namespace BusinessLogic.Services
{
	public class ProcessTextInput : IProcessInputService
	{
		private readonly IParser _parser;
		private readonly IFormatter _formatter;
        private readonly IValidator _validator;

        public ProcessTextInput(IParser parser, IFormatter formatter, IValidator validator)
        {
            _parser = parser;
            _formatter = formatter;
            _validator = validator;
        }

        public string ProcessInput(string input)
        {
            input = input.Trim();
            ValidateInput(input);

            var lines = _parser.Parse(input);

            return _formatter.Format(lines);
        }

        public void ValidateInput(string input)
        {
            _validator.Validate(input);
        }
    }
}

