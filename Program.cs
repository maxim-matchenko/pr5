using System;

// Предположительный класс/структура для рюкзака, 
// так как на фото видны только его поля и метод GetInfo()
public struct Bag
{
    public double capacity;
    public string brand;
    public string feature;
    public int pockets;
    public string type;

    public void GetInfo()
    {
        Console.WriteLine($"Описание рюкзака: \nБренд {brand}\nЛитраж: {capacity}\nКоличество карманов: {pockets}");
    }
}

public struct UserInfo
{
    public string login;
    public string password;
    public string mail;

    public UserInfo(string _login, string _password, string _mail)
    {
        login = _login;
        mail = _mail;
        password = _password;
    }
}

// //public struct Book
// //{
// //    public string name;
// //    public string author;
// //    public ushort year;
// //    public string publisher;
// //    public bool cenz;
// //    public void PrintInfo()
// //    {
// //        Console.WriteLine("+---Инфи по книге---+");
// //        if (cenz) Console.WriteLine($"Название: {name}\nАвтор: {author}\nДата издания: {year}");
// //        else Console.WriteLine($"Название: {name}\nАвтор: {author}\nДата издания: {year}\nИздательство: {publisher}");
// //    }
// //}

public struct Triangle
{
    public int sizeA;
    public int sizeB;
    public int sizeC;

    public void PrintInfo()
    {
        Console.WriteLine($"Треугольник со сторонами: A={sizeA}, B={sizeB}, C={sizeC}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Triangle abc;
        abc.sizeA = 5;
        abc.sizeB = 5;
        abc.sizeC = 8;
        abc.PrintInfo();

        // //Bag myBag;
        // //myBag.capacity = 4.5;
        // //myBag.brand = "Hugo Boss";
        // //myBag.feature = "Бронепробиваемый";
        // //myBag.pockets = 10;
        // //myBag.type = "детский";
        // //myBag.GetInfo();
    }
}

  