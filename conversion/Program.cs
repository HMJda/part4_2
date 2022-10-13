using System;
class Mile
{
    public double distance;
    public Mile(double distance)
    { // 생성자
        this.distance = distance;
    }
    // Mile operator: double to mile
    public static implicit operator Mile(double d) //묵시적 implicit
    {
        Mile m = new Mile(d);
        return m;
    }
    // Kilometer operator: Mile to Kilometor
    public static explicit operator Kilometer(Mile m) //명시적 explicit
    {
        return m.distance * 1.609;
    }
}
class Kilometer
{
    public double distance;
    public Kilometer(double distance)
    { // 생성자
        this.distance = distance;
    }
    // Kilometer operator: double to Kilo
    public static implicit operator Kilometer(double d) //묵시적 implicit
    {
        Kilometer k = new Kilometer(d);
        return k;
    }
    // Mile operator: Kilo to Mile
    public static explicit operator Mile(Kilometer k) //명시적 explicit
    {
        return k.distance / 1.609;
    }
}
class UserDefinedTypeConversionApp
{
    public static void Main()
    {
        Kilometer k = new Kilometer(100.0); // 객체 생성
        Mile m;
        m = (Mile)k;
        Console.WriteLine("{0} km = {1} mile", k.distance, m.distance);
        m = 65.0; // 암시적 형변환 (double to mile)
        k = (Kilometer)m; // 명시적 형변환
        Console.WriteLine("{0} mile = {1} km", m.distance, k.distance);
    }
}
