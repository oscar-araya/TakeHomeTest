// *************************************
// IParserService
// Oscar Araya
// ocleac@gmail.com
// 2023
//
// *************************************
using System;
namespace BusinessLogic.Services
{
	public interface IProcessInputService
	{
		string ProcessInput(string input);
		void ValidateInput(string input);
	}
}

