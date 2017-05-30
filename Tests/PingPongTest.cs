using Xunit;
using System;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void Generate_CountsUpToUserInput_ReturnsListOfInts()
    {
      //Arrange
      int userInput = 3;
      List<string> testOutput = new List<string> {"1","2","Ping"};
      //Act
      List<string> output = PingPongGenerator.Generate(userInput);
      //Assert
      Assert.Equal(testOutput, output);
    }

    [Fact]
    public void Generate_PingOutput_true()
    {
      //Arrange
      int userInput = 3;
      string testOutput = "Ping";
      //Act
      List<string> output = PingPongGenerator.Generate(userInput);
      //Assert
      Assert.Equal(true, testOutput == output[2]);
    }

    [Fact]
    public void Generate_PongOutput_true()
    {
      //Arrange
      int userInput = 5;
      string testOutput = "Pong";
      //Act
      List<string> output = PingPongGenerator.Generate(userInput);
      //Assert
      Assert.Equal(true, testOutput == output[4]);
    }

    [Fact]
    public void Generate_PingPongOutput_true()
    {
      //Arrange
      int userInput = 15;
      string testOutput = "PingPong";
      //Act
      List<string> output = PingPongGenerator.Generate(userInput);
      //Assert
      Assert.Equal(true, testOutput == output[14]);
    }

    // [Fact]
    // public void Generate_ErrorsOnStringInput_true()
    // {
    //   //Arrange
    //   string userInput = "Hello World";
    //   //Act
    //   var exception = Record.Exception(() => PingPongGenerator.Generate(userInput));
    //   //Assert
    //   Assert.NotNull(exception);
    //   Assert.IsType<GeneralException>(exception);
    // }
  }
}
