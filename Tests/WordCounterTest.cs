using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_ReturnAllInputs_allInputs()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "cat");
      List<string> expected = new List<string>{"cat", "cat"};
      List<string> output = testRepeatCounter.GetAllInputs();
      Assert.Equal(expected, output);
    }

    [Fact]
   public void RepeatCounter_ReturnIfMatch_MatchConfirmation()
   {
     RepeatCounter testRepeatCounter = new RepeatCounter("dog", "dog");
     List<string> expected = new List<string>{"dog", "Your word was in the sentence"};
     List<string> output = testRepeatCounter.CountRepeats();
     Assert.Equal(expected, output);
   }
  }
}
