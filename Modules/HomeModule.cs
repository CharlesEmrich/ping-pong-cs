using Nancy;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<string> model = new List<string> {};
        return View["pingpong.cshtml", model];
      };
      Post["/"] = _ => {
        List<string> newList = PingPongGenerator.Generate(int.Parse(Request.Form["input-num"]));
        return View["pingpong.cshtml", newList];
      };
    }
  }
}
