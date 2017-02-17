using Xunit;
using System;
using System.Collections.Generic;

namespace WordCountApp.Objects
{
  public class WordCountTest
  {
    [Fact]
      public void GetWord_ForUserInputWord_word()
      {
        RepeatCounter testCounter = new RepeatCounter();
        Assert.Equal("Hello", testCounter.GetWord("Hello"));
      }
    }
  }
