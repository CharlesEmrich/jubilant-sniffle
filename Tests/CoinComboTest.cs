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
      Assert.Equal(true, expectedOutput == output["quarters"]);
    }

    [Fact]
    public void GetChange_ReturnsNumberOfDimes_true()
    {
      int input = 60;
      int expectedOutput = 1;
      Dictionary<string, int> output = Change.GetChange(input);
      Assert.Equal(true, expectedOutput == output["dimes"]);
    }
  }
}
