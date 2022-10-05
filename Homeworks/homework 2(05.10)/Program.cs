Console.Clear();

Console.WriteLine("Введите число дня недели");

int day;

day = Convert.ToInt32(Console.ReadLine());

if(day <= 5)

{

Console.WriteLine("рабочий");

}

else
{

Console.WriteLine("выходной");

}
//не смог поставить, чтобы else заканчивал цикл на цифре 7. 