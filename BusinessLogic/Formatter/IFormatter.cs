// *************************************
// IFormatter
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
using BusinessLogic.DTO;

namespace BusinessLogic.Formatter
{
	public interface IFormatter
	{
		string Format(List<TokensDTO> tokens);
	}
}

