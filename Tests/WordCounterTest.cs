using Xunit;
using System;
using System.Collections.Generic;

namespace WordCountApp.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void GetWord_ReturnWord_word()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "cat");
      string expected = "cat";
      string output = testRepeatCounter.GetWord();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CountRepeats_ReturnOne_one()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog");
      int expected = 1;
      int output = testRepeatCounter.CountRepeats();
      Assert.Equal(expected, output);
    }
  }
}
