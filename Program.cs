public struct Triangle
{
    public int sizeA;
    public int sizeB;
    public int sizeC;

    // Метод для изменения/вывода инфо (уже есть у вас)
    public void PrintInfo()
    {
        Console.WriteLine($"Треугольник со сторонами: A={sizeA}, B={sizeB}, C={sizeC}");
        Console.WriteLine($"Периметр: {GetPerimeter()}");
        Console.WriteLine($"Площадь: {GetArea():F2}");
    }

    // Метод для расчета периметра
    public int GetPerimeter()
    {
        return sizeA + sizeB + sizeC;
    }

    // Метод для расчета площади по формуле Герона
    public double GetArea()
    {
        double p = GetPerimeter() / 2.0; // Полупериметр
        return Math.Sqrt(p * (p - sizeA) * (p - sizeB) * (p - sizeC));
    }
}
