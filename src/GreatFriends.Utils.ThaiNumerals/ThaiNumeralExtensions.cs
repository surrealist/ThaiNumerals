﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatFriends.Utils {

  public static class ThaiNumeralExtensions {

    private static string[] nativeDigits;

    static ThaiNumeralExtensions() {
      var th = CultureInfo.CreateSpecificCulture("th-TH");
      nativeDigits = th.NumberFormat.NativeDigits;      
    }

    public static string ToThaiNumerals(this byte value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this short value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this int value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this long value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this float value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this double value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this decimal value, string format = null) {
      return internalToThaiNumerals(value.ToString(format));
    }
    public static string ToThaiNumerals(this string value) {
      return internalToThaiNumerals(value);
    }

    private static string internalToThaiNumerals(string text) {
      var chars = text.ToCharArray();
      var sb = new StringBuilder(chars.Length);

      for (int i = 0; i < chars.Length; i++) {
        if ('0' <= chars[i] && chars[i] <= '9') {
          int n = (int)chars[i] - (int)'0';
          sb.Append(nativeDigits[n]);
        }
        else {
          sb.Append(chars[i]);
        }
      }
      return sb.ToString();
    }

    private static string internalToThaiNumerals_version1(string text) {
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
