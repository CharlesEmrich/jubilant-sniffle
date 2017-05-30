using System;
using System.Collections.Generic;

namespace CoinCombo.Objects
{
  public class Change
  {
    public static Dictionary<string, int> GetChange(int cents)
    {
      double subtotal = Convert.ToDouble(cents);
      Dictionary<string, int> output = new Dictionary<string, int> {{"quarters", 0}, {"dimes", 0}, {"nickels", 0}, {"pennies", 0}};
      output["quarters"] = Convert.ToInt32(Math.Floor(subtotal / 25.0));
      subtotal %= 25;
      output["dimes"]    = Convert.ToInt32(Math.Floor(subtotal / 10.0));
      subtotal %= 10;
      output["nickels"]  = Convert.ToInt32(Math.Floor(subtotal / 5.0));
      subtotal %= 5;
      output["pennies"]  = Convert.ToInt32(subtotal);

      return output;
    }
  }
}
