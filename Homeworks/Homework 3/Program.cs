Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром");
    }
}

