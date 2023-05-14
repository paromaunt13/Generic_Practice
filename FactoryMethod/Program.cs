/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс MyClass<T>, содержащий статический фабричный
метод - T FacrotyMethod(), который будет порождать экземпляры типа, указанного в качестве
параметра типа (указателя места заполнения типом – Т).
*/

var instance = MyClass<int>.FactoryMethod;
Console.WriteLine(instance.GetType());
class MyClass<T> where T: new()
{
    public static T FactoryMethod()
    {
        return new T();
    }
}