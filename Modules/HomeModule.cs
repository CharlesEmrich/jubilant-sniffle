using Nancy;
using System.Collections.Generic;
using CoinCombo.Objects;

namespace CoinCombo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Dictionary<string, int> blankDict = new Dictionary<string, int> {{"quarters", 0}, {"dimes", 0}, {"nickels", 0}, {"pennies", 0}};
        return View["index.cshtml", blankDict];
      };
      Post["/"] = _ => {
        Dictionary<string, int> ourDict = Change.GetChange(Request.Form["coins"]);
        return View["index.cshtml", ourDict];
      };
    }
  }
}
