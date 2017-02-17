using Xunit;
using System;
using System.Collections.Generic;

namespace WordCountApp.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void RepeatCounter_ReturnWord_word()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat");
      string expected = "cat";
      string output = testRepeatCounter.GetWord();
      Assert.Equal(expected, output);
    }
  }
}
