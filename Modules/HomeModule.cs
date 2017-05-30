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
        return View["pingpong.cshtml"];
      };
    }
  }
}
