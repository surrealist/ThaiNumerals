using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatFriends.Utils;

namespace GreatFriends.Utils.ThaiNumeralsTests {

  public class ThaiNumeralExtensionsTests {

    /// <summary>
    /// แสดงข้อความค่าตัวเลขด้วยตัวอักษรเลขไทย 
    /// เช่น ค่า 12345.67 เป็น "๑๒๓๔๕.๖๗"
    /// </summary>
    [TestFixture]
    public class TheToThaiNumeralsMethod {      
      
      [Test]
      public void GeneralUsage_ShouldBeUsableWithNumericTypes() {
        int valInt32       = 123;
        long valInt64      = 123L;
        float valSingle    = 123F;
        double valDouble   = 123D;
        decimal valDecimal = 123M;
        string valString   = "123";

        string strInt32    = valInt32.ToThaiNumerals();
        string strInt64    = valInt64.ToThaiNumerals();
        string strSingle   = valSingle.ToThaiNumerals();
        string strDouble   = valDouble.ToThaiNumerals();
        string strDecimal  = valDecimal.ToThaiNumerals();
        string strString   = valString.ToThaiNumerals();
      }

      [Test]
      public void ZeroToNine() {
        double val = 1234567890.123;
        string str = val.ToThaiNumerals();
        Assert.AreEqual("๑๒๓๔๕๖๗๘๙๐.๑๒๓", str);
      }

      [Test]
      public void NegativeValue() {
        double val = -18.25;
        string str = val.ToThaiNumerals();
        Assert.AreEqual("-๑๘.๒๕", str);
      }

      [Test]
      public void ShouldIgnoreAndKeepExtraSpaceAsIs() {
        string val = " 135 ";
        string str = val.ToThaiNumerals();
        Assert.AreEqual(" ๑๓๕ ", str);
      }

      [Test]
      public void IgnoreThaiDigits() {
        string val = "ที่ ๒๕๕๗/2";
        string str = val.ToThaiNumerals();
        Assert.AreEqual("ที่ ๒๕๕๗/๒", str);
      }

      [Test]
      public void UseSimpleFormatString() {
        var val = 2398.657;
        var str = val.ToThaiNumerals("n2");
        Assert.AreEqual("๒,๓๙๘.๖๖", str);
      }


      [Test]
      public void UseNegativeFormat() {
        var val = -2398.657;
        var str = val.ToThaiNumerals("#,##0.00;(#,##0.00);-");
        Assert.AreEqual("(๒,๓๙๘.๖๖)", str);
      }

    }
  }
}
