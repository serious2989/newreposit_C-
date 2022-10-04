// Функции, процедура

Console.Clear();
void f(ref int x) // процедура
{
    x = x + 10;
}


int n = 5;
Console.WriteLine(n);
f(ref n);
Console.WriteLine(n);
// сколько значений принимаем то столько и передаем
// сколько значений передаем столько и принимаем