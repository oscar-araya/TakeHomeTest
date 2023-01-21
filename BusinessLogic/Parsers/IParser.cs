// *************************************
// IParser
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
using BusinessLogic.DTO;

namespace BusinessLogic.Parsers
{
	public interface IParser
	{
		List<LineTokens> Parse(string input);
	}
}

