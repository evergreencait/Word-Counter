using Nancy;
using System;
using System.Collections.Generic;

namespace WordCountApp.Objects
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _phraseInput;
    private int _score;
    string[] _phraseArray;

    public RepeatCounter (string wordInput , string phraseinput)
    {
      _wordInput = wordInput;
      _phraseArray = _phraseInput.Split(' ');
    }
    public string GetWord()
    {
      return _wordInput;
    }

    public int CountRepeats()
    {
      _score = 0;

      for (int i = 0; i <= _phraseArray.Length; i++)
      {
        if (_wordInput == _phraseArray[i])
        {
           _score +=1;
        }
      }
      return _score;
    }
  }
}
