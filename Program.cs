Console.Clear();

Console.WriteLine("введите числo");

int a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
    Console.WriteLine($"{a} chetnoe");
else
    Console.WriteLine($"{a} ne chetnoe");