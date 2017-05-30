using Xunit;
using System;
using System.Collections.Generic;
using CoinCombo.Objects;

namespace CoinCombo
{
  public class CoinComboTest
  {
    [Fact]
    public void GetChange_ReturnsAnInteger_true()
    {
      int input = 12;
      int expectedOutput = 12;
      int output = Change.GetChange(input);
      Assert.Equal(true, expectedOutput == output);
    }
  }
}
