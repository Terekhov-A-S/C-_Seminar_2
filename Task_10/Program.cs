// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Искусственный интеллект Core 2.0 приветствует Вас!");
Console.Write("Пожалуйста, введите трехзначное число для моей магии ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Замечательно! Теперь я постараюсь вывести на экран первую и крайнюю цифру числа {a}");
if ((a >= 1000) || (a < 100)) { Console.WriteLine($"Вы ввели не трехзначное число {a}, магии не будет!"); }
else Console.WriteLine($"Мне кажется, будет так: {a / 100} и {a % 10}");
Console.Write("Всего доброго! Буду рад пообщаться снова! ");
