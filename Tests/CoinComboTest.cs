using Xunit;
using System;
using System.Collections.Generic;
using CoinCombo.Objects;

namespace CoinCombo
{
  public class CoinComboTest
  {
    [Fact]
    public void GetChange_ReturnsNumberOfQuarters_true()
    {
      int input = 50;
      int expectedOutput = 2;
      Dictionary<string, int> output = Change.GetChange(input);
      Assert.Equal(expectedOutput, output["quarters"]);
    }

    [Fact]
    public void GetChange_ReturnsNumberOfDimes_true()
    {
      int input = 60;
      int expectedOutput = 1;
      Dictionary<string, int> output = Change.GetChange(input);
      Assert.Equal(expectedOutput, output["dimes"]);
    }

    [Fact]
    public void GetChange_ReturnsNumberOfNickels_true()
    {
      int input = 65;
      int expectedOutput = 1;
      Dictionary<string, int> output = Change.GetChange(input);
      Assert.Equal(expectedOutput, output["nickels"]);
    }

    [Fact]
    public void GetChange_ReturnsNumberOfPennies_true()
    {
      int input = 74;
      int expectedOutput = 4;
      Dictionary<string, int> output = Change.GetChange(input);
      Assert.Equal(expectedOutput, output["pennies"]);
    }
  }
}
