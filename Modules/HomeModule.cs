using Nancy;
using WordCounterApp.Objects;
using System.Collections.Generic;


namespace WordCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
        return View["results.cshtml", newRepeatCounter];
      };
    }
  }
}
