// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое   число большее, а какое меньшее.
Console.WriteLine("Введите 1e число:");
int num_A = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите 2e число:");
int num_B = Convert.ToInt32(Console.ReadLine()!);
int max, min;
if (num_A > num_B)
{
   max = num_A;
   min = num_B;
}
else
{
   max = num_B;
   min = num_A;
}

Console.WriteLine($"max= {max} > min = {min}");


