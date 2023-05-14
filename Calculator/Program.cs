/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс калькулятор (Calculator). Класс Calculator должен
содержать два универсальных параметра типа T1, T2 (Calculator <T1, T2>). В теле класса создайте
методы для сложения, вычитания и умножения, которые в качестве аргументов должны
принимать T1, T2, и возвращать тип double (можно использовать класс Convert или приведение
типов)
*/

var resultAdd = Calculator<int, double>.Add(10, 140.503);
var resultSubtract = Calculator<int, double>.Subtract(200, 23.984);
var resultMultiply = Calculator<int, double>.Multiply(32, 8.456);

Console.WriteLine(resultAdd);
Console.WriteLine(resultSubtract);
Console.WriteLine(resultMultiply);

class Calculator<T1, T2>
{
    static public double Add(T1 a, T2 b) 
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }
    static public double Subtract(T1 a, T2 b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }
    static public double Multiply(T1 a, T2 b)
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }
}