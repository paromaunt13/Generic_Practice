/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте обобщенный класс книга (Book). Класс Book должен
содержать универсальный параметра типа T (Book <T>). В теле класса создайте два закрытых
поля: Name – имя книги (private string Name) и Price – (обобщенныйтип) цена книги
(private T Price). Также создайте свойства для доступа к выше описанным полям. После чего
создайте метод Show() который будет вывод название книги и ее цену. В методе Main()
создайте экземпляры обобщенного типа, где Т это int и где Т это double.
*/

Book<int> book1 = new() { Name = "First Book", Price = 100 };
Book<double> book2 = new() { Name = "Second Book", Price = 143.89 };

book1.ShowInfo();
book2.ShowInfo();
class Book<T>
{
    private string name;
    private T price;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public T Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Название книги: {Name}");
        Console.WriteLine($"Цена: {Price}");
    }
}
