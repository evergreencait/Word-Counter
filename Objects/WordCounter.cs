using Nancy;
using System;
using System.Collections.Generic;

namespace WordCountApp
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _wordLower;

    public RepeatCounter (string wordInput)
    {
      _wordInput = wordInput;
      _wordLower = _wordInput.ToLower();
    }

    public string GetWord()
    {
      return _wordInput;
    }

  }
}
