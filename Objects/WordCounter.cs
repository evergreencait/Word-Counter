using Nancy;
using System;
using System.Collections.Generic;

namespace WordCountApp
{
  public class RepeatCounter
  {
    private string _wordInput;

    public RepeatCounter (string wordInput)
    {
      _wordInput = wordInput;
    }

    public string GetWord()
    {
      return _wordInput;
    }
  }
}
