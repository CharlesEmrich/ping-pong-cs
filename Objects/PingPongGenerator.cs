using System;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    public static List<string> Generate(int input)
    {
      List<string> output = new List<string> {};

      for (int index = 1; index <= input; index ++)
        {
          string element = "";
          if (index % 3 == 0) {
          element += "Ping";
          }
          if (index % 5 == 0) {
          element += "Pong";
          }
          if (element == "") {
          element = index.ToString();
          }
          output.Add(element);
        }
      return output;
    }
  }
}
