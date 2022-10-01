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

/*Задача 2: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2 && num_1 > num_3)

    Console.WriteLine($"Число {num_1} больше {num_2} и {num_3}");

else if (num_2 > num_1 && num_2 > num_3)

    Console.WriteLine($"Число {num_2} больше {num_1} и {num_3}");

else 

    Console.WriteLine($"Число {num_3} больше {num_1} и {num_2}");

