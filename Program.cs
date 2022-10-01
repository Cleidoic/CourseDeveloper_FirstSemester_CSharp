/*Задача 1: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int number_1 = Convert.ToInt32(Console.ReadLine()); //int.Parse(number_1);
int number_2 = Convert.ToInt32(Console.ReadLine()); //int.Parse(number_1);

if (number_1 > number_2)

    Console.WriteLine($"Число {number_1} больше {number_2}");

else

    Console.WriteLine($"Число {number_2} больше {number_1}");