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
    /// เช่น ค่า 12345.67 เป็น "๑๒,๓๔๕.๖๗"
    /// </summary>
    [TestFixture]
    public class TheToThaiNumeralsMethod {      
      
      [Test]
      public void GeneralUsage_ShouldBeUsableWithNumericTypes() {
        int valInt32       = 123;
        long valInt64      = 123L;
        float valSingle    = 123F;
        double valDouble   = 123.0;
        decimal valDecimal = 123M;
        
        string strInt32 = valInt32.ToThaiNumerals();
        string strInt64 = valInt64.ToThaiNumerals();
        string strSingle = valSingle.ToThaiNumerals();
        string strDouble = valDouble.ToThaiNumerals();
        string strDecimal = valDecimal.ToThaiNumerals();         
      }

      [Test]
      public void ZeroToNine() {
        double val = 1234567890.123;

        string str = val.ToThaiNumerals();

        Assert.AreEqual("๑๒๓๔๕๖๗๘๙๐.๑๒๓", str);
      }
    }
  }
}
