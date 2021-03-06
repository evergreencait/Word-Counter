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
    private string _wordLower;
    private string _phraseLower;
    private List<string> _allInputs = new List<string>();

    public RepeatCounter (string phraseInput, string wordInput)
    {
      _phraseInput = phraseInput;
      _wordInput = wordInput;
      _wordLower = _wordInput.ToLower();
      _phraseLower = _phraseInput.ToLower();
    }

    // public List<string> GetAllInputs()
    // {
    //   _allInputs.Add(_phraseLower);
    //   _allInputs.Add(_wordLower);
    //   return _allInputs;
    // }
    //
    // public List<string> ReturnSentence()
    // {
    //   string[] words = _phraseInput.Split(' ');
    //   foreach(string word in words)
    //   {
    //     if (word == _wordLower)
    //     {
    //       _allInputs.Add(_wordLower);
    //       _allInputs.Add("Your word was in the sentence");
    //     }
    //   }
    //   if (_allInputs.Count == 0)
    //   {
    //     _allInputs.Add("Your word was not in the sentence");
    //   }
    //   return _allInputs;
    // }

    public int CountRepeats()
    {
      _score = 0;
      string[] words = _phraseLower.Split(' ');
      string[] inputwords = _wordLower.Split(' ');
      for (int i = 0; i <= inputwords.Length-1; i++)
      {
        for (int j = 0; j <= words.Length-1; j++)
        {
          if (inputwords[i] == words[j])
          {
            _score += 1;
          }
        }
      }
      return _score;
    }
  }
}
