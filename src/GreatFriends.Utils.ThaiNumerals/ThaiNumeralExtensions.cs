using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatFriends.Utils {

  public static class ThaiNumeralExtensions {

    public static string ToThaiNumerals(this int value) {
      return internalToThaiNumerals(value.ToString());
    }
    public static string ToThaiNumerals(this long value) {
      return internalToThaiNumerals(value.ToString());
    }
    public static string ToThaiNumerals(this float value) {
      return internalToThaiNumerals(value.ToString());
    }
    public static string ToThaiNumerals(this double value) {
      return internalToThaiNumerals(value.ToString());
    }
    public static string ToThaiNumerals(this decimal value) {
      return internalToThaiNumerals(value.ToString());
    }
    public static string ToThaiNumerals(this string value) {
      return internalToThaiNumerals(value);
    }

    private static string internalToThaiNumerals(string text) {
      const int diff = (int)'๑' - (int)'1';
      var sb = new StringBuilder();
      foreach (char ch in text) {
        if ('0' <= ch && ch <= '9')
          sb.Append((char)((int)ch + diff));
        else
          sb.Append(ch);
      }
      return sb.ToString();
    }
  }
}
