ThaiNumerals
============

Convert a value to Thai Numerals text. Ex. from 1234567890 to "๑๒๓๔๕๖๗๘๙๐"


This is general usages, all results are "๑๒๓"

    int valInt32       = 123;
    long valInt64      = 123L;
    float valSingle    = 123F;
    double valDouble   = 123D;
    decimal valDecimal = 123M;

    string strInt32 = valInt32.ToThaiNumerals();
    string strInt64 = valInt64.ToThaiNumerals();
    string strSingle = valSingle.ToThaiNumerals();
    string strDouble = valDouble.ToThaiNumerals();
    string strDecimal = valDecimal.ToThaiNumerals();    

You can formatting value before convert it to Thai numerals:

    decimal price = 1500.75m;
    string  str   = price.ToString("#,##0.00");
    string  th    = str.ToThaiNumerals(); // ๑,๕๐๐.๗๕
    
or pass the format directly:

    string  th    = price.ToThaiNumerals("#,##0.00");
    
    
