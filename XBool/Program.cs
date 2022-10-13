using System;
class XBool
{
    public bool b;
    // XBool 클래스 형을 bool 형으로 명시적으로 변환하는 연산자 중복
    public static explicit operator bool(XBool x)
    {
        Console.WriteLine("In the explicit conversion-operator bool ...");
        return x.b;
    }
    // XBool 형에 대한 true 연산자의 중복 (반환형 : bool)
    public static bool operator true(XBool x)
    {
        Console.WriteLine("In the operator true ...");
        return x.b ? true : false;
    }
    // XBool 형에 대한 false 연산자의 중복
    public static bool operator false(XBool x)
    {
        Console.WriteLine("In the operator false ...");
        return x.b ? false : true;
    }
}
class XBoolApp
{
    public static void Main()
    {
        XBool xb = new XBool();
        xb.b = true;
        if (xb) // invoke operator true (클래스에 대한 true 연산자 호출)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        Console.WriteLine((bool)xb); // invoke conversion-operator bool: 명시적 bool 형변환 연산자 호출
    }
}
