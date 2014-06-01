ThaiNumerals
============

Convert a value to Thai Numerals text. Ex. from 123 to "๑๒๓"


This is general usages, all results are "๑๒๓"

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
