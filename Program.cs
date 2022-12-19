Console.Clear();

Console.WriteLine("введите 2 числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a==b)
    Console.WriteLine($"{a}={b}");
if (a>b)
    Console.WriteLine($"{a} больше {b}");
if (a<b)
{
    Console.WriteLine($"{b} больше {a}");
}