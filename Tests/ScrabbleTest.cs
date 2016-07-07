using Xunit;
using System;

namespace Scrabble
{
  public class ScrabbleTest : IDisposable
  {
    [Fact]
    public void GetScore_LetterA_1()
    {
      //Arrange
      Scrabble scrabble = new Scrabble();
      //Act
      int result = scrabble.GetLetterScore("A");
      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void GetScore_Word_Hello_8()
    {
      //Arrange
      Scrabble scrabble = new Scrabble();
      //Act
      int result = scrabble.GetWordScore("hello");
      //Assert
      Assert.Equal(8, result);
    }
    [Fact]
    public void GetScore_Number_In_Word()
    {
      //Arrange
      Scrabble scrabble = new Scrabble();
      //Act
      int result = scrabble.GetWordScore("hello7");
      //Assert
      Assert.Equal(8, result);
    }



    public void Dispose()
    {

    }
  }
}
