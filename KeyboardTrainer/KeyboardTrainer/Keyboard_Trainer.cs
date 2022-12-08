using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardTrainer
{
	class Keyboard_Trainer
	{
		private const string LOWER_CASE = "qwertyuiopasdfghjklzxcvbnm";
		private const string UPPER_CASE = "QWERTYUIOPASDFGHJKLZXCVBNM";
		private const string ADDITIONAL_SYMBOLS = "1234567890`-=[]\\;',./~!@#$%^&*()_+{}|:\"<>?";


		public string SourceString { get; private set; }
		public string SourceCorrectString { get; private set; }
		public string InputCorrectString { get; private set; }

		public int SpeedOfTyping { get; private set; }
		public int CountOfFails { get; private set; }

		private int _countOfCorrectChars;

		public void UpdateString()
		{
			SourceCorrectString += SourceString[0];
			InputCorrectString += SourceString[0];

			SourceString = SourceString.Remove(0, 1);
		}

		public void UpdateCountOfCorrectChars() => ++_countOfCorrectChars;
		public void UpdateCountOfFails() => ++CountOfFails;
		public void UpdateSpeedOfTyping(int amountOfElapsedTime) => SpeedOfTyping = (_countOfCorrectChars * 60) / amountOfElapsedTime;

		public void GenerateString(int difficulty, bool? upperLower_case, bool? symbols)
		{
			SourceCorrectString = "";
			InputCorrectString = "";

			StringBuilder builder = new StringBuilder();
			Random random = new Random();


			string s = "";
			int ind;
			for (int i = 0; i < difficulty; )
			{
				ind = random.Next(0, LOWER_CASE.Length);
				if (s.IndexOf(LOWER_CASE[ind]) == -1)
				{
					s += LOWER_CASE[ind];
					++i;
				}
			}

			if ((bool)upperLower_case)
			{
				s += s.ToUpper();
				Generate(ref builder, s);
			}
			else
			{
				Generate(ref builder, s);
			}

			if ((bool)symbols)
			{
				int tmp;
				int countOfSymbols = random.Next(5, 15);
				List<int> alreadyHas = new List<int>();

				for (int i = 0; i < countOfSymbols; )
				{
					tmp = random.Next(0, builder.Length);

					if (alreadyHas.FindIndex(f => f == tmp) == -1)
					{
						alreadyHas.Add(tmp);
						builder.Remove(tmp, 1);
						builder.Insert(tmp, ADDITIONAL_SYMBOLS[random.Next(0, ADDITIONAL_SYMBOLS.Length)]);

						i++;
					}

				}
			}

			SourceString = builder.ToString();
		}
		private void Generate(ref StringBuilder builder, string s)
		{
			int wordLength;
			Random random = new Random();


			for (int i = 0; i < 67; i++)
			{
				wordLength = random.Next(1, 10);

				if (i + wordLength < 67)
				{
					i += wordLength;
				}
				else
				{
					i += wordLength;
					while (i != 67)
					{
						--wordLength;
						--i;
					}
				}

				for (int j = 0; j < wordLength; j++)
					builder.Append(s[random.Next(0, s.Length)]);

				if (i<67)
					builder.Append(' ');
			}
		}

		public void Reset()
		{
			SourceString = "";
			SourceCorrectString = "";
			InputCorrectString = "";
			SpeedOfTyping = 0;
			CountOfFails = 0;
			_countOfCorrectChars = 0;
		}
	}
}
