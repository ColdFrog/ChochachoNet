/*
 * Created by SharpDevelop.
 * User: cdaniels
 * Date: 5/14/2015
 * Time: 11:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Chochachonet
{
	/// <summary>
	/// Description of Anagraph.
	/// </summary>
	public class Anagraph
	{
		public static Dictionary<char, int> LetterValues = new Dictionary<char, int>()
		{
			{'A', 5},
			{'B', 5},
			{'C', 3},
			{'D', 4},
			{'E', 5},
			{'F', 4},
			{'G', 3},
			{'H', 5},
			{'I', 2},
			{'J', 3},
			{'K', 4},
			{'L', 3},
			{'M', 8},
			{'N', 6},
			{'O', 4},
			{'P', 4},
			{'Q', 5},
			{'R', 5},
			{'S', 3},
			{'T', 4},
			{'U', 4},
			{'V', 4},
			{'W', 8},
			{'X', 4},
			{'Y', 3},
			{'Z', 4},
			{'-', 1}
		};
		public Anagraph()
		{
		}
		
		public static bool compareWords(string word1, string word2)
		{
			if (word1.Trim(' ').Equals(String.Empty) || word2.Trim(' ').Equals(String.Empty))
			{
				throw new Exception();
			}
			int word1Val = quantifyWord(word1);
			int word2Val = quantifyWord(word2);
			return word1Val == word2Val;
		}
		
		private static int quantifyWord(string word)
		{
			char[] currWord = word.ToUpper().ToCharArray();
			int currWordVal = 0;
			for (int i = 0; i < currWord.Length; i++)
			{
				currWordVal += LetterValues[currWord[i]];
			}
			return currWordVal;
		}
	}
}
