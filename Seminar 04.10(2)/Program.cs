﻿Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m || m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
