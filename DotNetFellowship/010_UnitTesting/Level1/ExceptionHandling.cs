using System;
namespace _010_UnitTesting;
public class ExceptionHandling
{
    public int Divide(int a, int b)
    {
        if (b == 0) throw new ArithmeticException("Division by zero");
        return a / b;
    }
}
