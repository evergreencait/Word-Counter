using Nancy;
using System;
using System.Collections.Generic;

namespace WordCountApp
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;

    public RepeatCounter (string wordInput, string sentenceInput)
    {
      _wordInput = wordInput;
      _sentenceInput = sentenceInput;
    }

    public string GetWord()
    {
      return _wordInput;
    }
  }
}
