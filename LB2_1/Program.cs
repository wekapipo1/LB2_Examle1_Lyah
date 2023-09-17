using System;

public class Triangle
{
    double a, b, c; //поля
    public double A //Властивість для правласнення значення полю а
    {
        set
        {
            if (value > 0) a = value;
            else Console.WriteLine("1 сторона не може бути вiд'ємною");
        }
    }
    public double B //Властивість для правласнення значення полю b
    {
        set
        {
            if (value > 0) b = value;
            else Console.WriteLine("2 сторона не може бути вiд'ємною");
        }
    }
    public double C //Властивість для правласнення значення полю c
    {
        set
        {
            if (value > 0) c = value;
            else Console.WriteLine("3 сторона не може бути вiд'ємною");
        }
    }
    public bool Correct() //метод, який провіряє існування такого об'єкта
    {
        bool p = false;
        if (a < b + c && b < a + c && c < a + b) p = true;
        return p;
    }    
    public void Print() //метод, який виводе на екран поля
    { Console.WriteLine("a={0} b={1} c={2}", a, b, c); }   
    public double Perimetr()  //метод, який обчислює пeриметр
    {
        double p = a + b + c;
        return p;
    }    
    public double Sqr() //метод, який обчислює площу
    {
        double p = this.Perimetr() / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }   
}
class Program
{
    static void Main(string[] args)
    {
        double x, y, z;
        try
        {
            //вводимо сторони трикутника
            Console.Write("x="); x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y="); y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z="); z = Convert.ToDouble(Console.ReadLine());
            //створення об'єкту з 0 полями
            Triangle t = new Triangle();
            //привласнення значень полям за допомогою властивостей
            t.A = x; t.B = y; t.C = z;
            //вивод на  екран значень полів
            t.Print();
            //перевірка існування об'єкта
            if (t.Correct()) //об'єкт існує
            {
                //застосування методів
                double p = t.Perimetr();
                double s = t.Sqr();
                //виводимо результат
                Console.WriteLine("P={0} S={1:F3}", p, s);
            }
            //об'єкт не уснує
            else Console.WriteLine("Такого трикутника не iснує");

        }
        catch
        {
            //інші можливі виключення
            Console.WriteLine("Помилка!!!");
        }
        Console.ReadKey();
    }
}