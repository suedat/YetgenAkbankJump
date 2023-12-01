using System;
namespace YetGenAkbankJump.OOPConsole.Utilities
{
	public class PasswordGenerator
	{
		private readonly Random _random;
		//written like _random because this area private & readonly
		//readonly -> bir kere atıyoruz bir daha değiştiremiyoruz

		public PasswordGenerator()
		{
			_random = new Random();
		}

		public string Generate(int passwordLenght)
		{
			string password = string.Empty;

			for (int i = 0; i < passwordLenght; i++)
			{
				var randomNumber = _random.Next(0, 10000);

				if(randomNumber % 2 == 0)
				{
                password += _random.Next(0, 10).ToString();
				}
				else
				{
					var randomNumberForChars = _random.Next(0, 10000);

					if(randomNumberForChars % 2 == 0)
					{
						password += Convert.ToChar(_random.Next(65, 91));

					}
					else
					{
						password += Convert.ToChar(_random.Next(97,123));
					}
				}
			}
			return password;
		}
	}
}

