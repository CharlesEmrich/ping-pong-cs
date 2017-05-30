using Xunit;
using System;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class PingPongTest
  {
    // [Fact]
    // public void Generate_CountsUpToUserInput_ReturnsListOfInts()
    // {
    //   //Arrange
    //   int userInput = 3;
    //   List<string> testOutput = new List<string> {"1","2","3"};
    //   //Act
    //   List<string> output = PingPongGenerator.Generate(userInput);
    //   //Assert
    //   Assert.Equal(testOutput, output);
    // }

    [Fact]
    public void Generate_PingOutput_true()
    {
      //Arrange
      int userInput = 3;
      List<string> testOutput = new List<string> {"1","2","Ping"};
      //Act
      List<string> output = PingPongGenerator.Generate(userInput);
      //Assert
      bool test = testOutput[2] == output[2];
      Assert.Equal(true, test);
    }
  }
}
