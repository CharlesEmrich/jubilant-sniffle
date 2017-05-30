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
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
