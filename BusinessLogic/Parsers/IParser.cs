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
		List<TokensDTO> Parse(string input);
	}
}

