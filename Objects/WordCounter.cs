using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
  public class RepeatCounter
  {
    private string _phraseInput;
    private string _wordInput;
    private List<string> _allInputs = new List<string>();

    public RepeatCounter (string phraseInput, string wordInput)
    {
      _phraseInput = phraseInput;
      _wordInput = wordInput;
    }

    public List<string> GetAllInputs()
    {
      _allInputs.Add(_phraseInput);
      _allInputs.Add(_wordInput);
      return _allInputs;
    }
  }
}
