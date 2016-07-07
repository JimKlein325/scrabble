using System;
using System.Collections.Generic;
using System.Text;


namespace Scrabble
{
  public class Scrabble
  {
    private Dictionary<int, string[]> _letterScoresAndLetterArrays= new Dictionary<int, string[]> ();
    public Scrabble()
    {
      _letterScoresAndLetterArrays.Add(1, new string[] {"A", "E","I", "O", "U", "L", "N", "R", "S", "T"});
      _letterScoresAndLetterArrays.Add(2, new string[] {"D", "G"});
      _letterScoresAndLetterArrays.Add(3, new string[] {"B", "C", "M", "P"});
      _letterScoresAndLetterArrays.Add(4, new string[] {"F", "H", "V", "W", "Y"});
      _letterScoresAndLetterArrays.Add(5, new string[] {"K"});
      _letterScoresAndLetterArrays.Add(8, new string[] {"J", "X"});
      _letterScoresAndLetterArrays.Add(10, new string[] {"Q", "Z"});

    }

    private bool MatchLetterInArray(string letter, string[] letters)
    {
      foreach(string s in letters)
      {
        if(s == letter) return true;
      }
      return false;
    }
    public int GetLetterScore(string letter)
    {
      int letterScore = 0;
      foreach (KeyValuePair<int, string[]> pair in _letterScoresAndLetterArrays)
      {
        string[] letters = pair.Value;
        bool letterMatches = MatchLetterInArray(letter, letters);
        if(letterMatches)
        {
          letterScore = pair.Key;
          Console.WriteLine(letter + " " + letterScore);
          return letterScore;
        }
      }

      return letterScore;
    }

    public int GetWordScore(string word)
    {
      string cappedWord = word.ToUpper();
      int wordScore = 0;
      char[] chars = cappedWord.ToCharArray();
      foreach(char c in chars)
      {
        string letter = c.ToString();
        int letterScore = GetLetterScore(letter);
        if(letterScore > 0)
        {
          wordScore = wordScore + letterScore;
          Console.WriteLine("Wordscore: " + wordScore);
        }
      }
      return wordScore;
    }
    //
  }

}
