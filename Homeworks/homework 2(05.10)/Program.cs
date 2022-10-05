// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// (+проверка является ли число трехзначным)

Console.Write("Напишите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numberthree=DigitNumber(num);// Проверка трехзначного числа
if (numberthree ==3)
   {
    int result = num / 10 % 10; // Находим вторую цифру числа
    Console.WriteLine("Второе число "+ num + " - " + result);
   }
else
   {
    Console.WriteLine("Внимание "+ num + " это не трехзначное число" );
   }


int DigitNumber (int num)// Function to find number of digit
{
int numberthree=0;
double count = num;
while (count>=1)
   {
    count=count/10;
    numberthree++;
   }
return numberthree;
}
