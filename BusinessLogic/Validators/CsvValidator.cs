// *************************************
// CsvValidator
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
namespace BusinessLogic.Validators
{
	public class CsvValidator : IValidator
	{
        const string SINGLE_QUOTE = "\"";


        public void Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new Exception("Input cannot be empty");

            if (!input.StartsWith(SINGLE_QUOTE) || !input.EndsWith(SINGLE_QUOTE))
                throw new Exception("Bad CSV format");
        }
    }
}

