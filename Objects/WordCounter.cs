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

    public List<string> CountRepeats()
    {
      string[] words = _phraseInput.Split(' ');
      foreach(string word in words)
      {
        if (word == _wordInput)
        {
          _allInputs.Add(_wordInput);
          _allInputs.Add("Your word was in the sentence");
        }
      }
      if (_allInputs.Count == 0)
      {
        _allInputs.Add("Your word was not in the sentence");
      }
      return _allInputs;
    }
  }
}
