using System;
using System.Text;

namespace YetGenAkbankJump.OOPConsole.Utilities
{
	public class PasswordGenerator
	{
		private readonly Random _random;
		//written like _random because this area private & readonly
		//readonly -> bir kere atıyoruz bir daha değiştiremiyoruz
		private const string Numbers = "0123456789";
        private const string SpecialChars = "!@#$%^&*()";
        private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Full = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()";

        public PasswordGenerator()
		{
			_random = new Random();
		}

		public string Generate(int passwordLenght, bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool includeSpecialChars)
		{
			var charsBuilder = new StringBuilder();

			if (includeNumbers)
				charsBuilder.Append(Numbers);

			if (includeLowerCase)
				charsBuilder.Append(LowerCaseChars);

            if (includeUpperCase)
                charsBuilder.Append(UpperCaseChars);

            if (includeSpecialChars)
                charsBuilder.Append(SpecialChars);

			var acceptedChars = charsBuilder.ToString();

			var passwordBuilder = new StringBuilder();

            for (int i = 0; i < passwordLenght; i++)
			{
				var randomIndex = _random.Next(0, acceptedChars.Length);

				passwordBuilder.Append(acceptedChars[randomIndex]);
				
			}
			return passwordBuilder.ToString();
			//stringBuilder is a class so added ToString()
		}
	}
}

