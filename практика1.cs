class Program
{
    static void Main(string[] args)
    {
        int a, b = 0;
        Console.WriteLine("Введите первое число:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = int.Parse(Console.ReadLine());
        Subst.Math(a, b);
        Console.ReadKey();
    }
}
class Subst
{
    public static void Math(int a, int b)
    {
        Console.WriteLine("Сумма равна:{0}", a + b);
    }
}