using Nancy;
using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
  public class RepeatCounter
  {
    private string _phraseInput;
    private string _wordInput;
    private int _score;
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
      _score = 0;
      string[] words = _phraseInput.Split(' ');
      for (int i = 0; i <= words.Length-1; 1++)
      {
        for (int j = 0; j <= allInputs.Length-1, 1++)
        {
          if (words[i] == allInputs[j])
          {
            _allInputs.Add(_wordInput);
            _allInputs.Add("Your word was in the sentence");
            _score +=1;
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
}
