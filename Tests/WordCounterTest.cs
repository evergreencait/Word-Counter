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
      RepeatCounter testRepeatCounter = new RepeatCounter("rabbit", "rabbit");
      List<string> expected = new List<string>{"rabbit", "Your word was in the sentence"};
      List<string> output = testRepeatCounter.ReturnSentence();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void RepeatCounter_ReturnScore_Score()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("This is my dog and her dog", "dog");
      int expected = 2;
      int output = testRepeatCounter.CountRepeats();
      Assert.Equal(expected, output);
    }

    [Fact]
  public void RepeatCounter_ReturnCaseInsensitive_Score()
  {
    RepeatCounter testRepeatCounter = new RepeatCounter("This is my dog", "Dog");
    int expected = 1;
    int output = testRepeatCounter.CountRepeats();
    Assert.Equal(expected, output);
  }
  }
}
