using System;
using System.Collections.Generic;
using System.Text;


namespace RockScissors
{
  public class FindReplace
  {
    // private string _searchPhrase;
    // private string _inputString;
    // private string _replaceString;

    public FindReplace()
    {

    }
    public bool Find(string searchPhrase, string toFind)
    {
      return searchPhrase.ToLower().Contains(toFind.ToLower());
    }
    public string Replace(string searchPhrase, string toReplace, string newString)
    {
      return searchPhrase.Replace(toReplace, newString);
    }
    public string ReplaceMultiple(string searchPhrase, string toReplace, string newString)
    {
      StringBuilder sb = new StringBuilder();
      int charCounter = searchPhrase.Length;

      string placeholder = searchPhrase;
      while (Find(placeholder, toReplace))
      {
        char[] phrase = placeholder.ToCharArray();
        int indexOfMatch = GetIndexOfOccurence(placeholder, toReplace);

        Console.WriteLine("phrase: " + placeholder);
        for(int i = 0; i < indexOfMatch ; i++ )
        {
          sb.Append(phrase[i]);
        }

        sb.Append(newString);
        int cutSize = indexOfMatch + toReplace.Length;
        Console.WriteLine("cutSize: " + cutSize + "phraseLength" + phrase.Length);
        //if(phrase.Length > cutSize){
          placeholder = placeholder.Remove(0, cutSize);
          charCounter = charCounter - cutSize;
        // }
        // else{
                    // placeholder = "";
        // }

      }
      char[] array = searchPhrase.ToCharArray();

      for (int i = array.Length - charCounter ; i < array.Length ; i++)
      {
        sb.Append(array[i]);
      }

      return sb.ToString();
    }
    public int GetIndexOfOccurence(string searchPhrase, string toFind)
    {
      return searchPhrase.ToLower().IndexOf(toFind.ToLower());
    }
  }

}
