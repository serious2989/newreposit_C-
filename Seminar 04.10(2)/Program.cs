//Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
