// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Искусственный интеллект Core 2.0 приветствует Вас!");
Console.WriteLine("Пожалуйста, введите цифру, обозаначающую день недели и я проверю, является ли этот день выходным ");
// Console.WriteLine("Понедельник - 1");
// Console.WriteLine("Вторник - 2");
// Console.WriteLine("Среда - 3");
// Console.WriteLine("Четверг - 4");
// Console.WriteLine("Пятница - 5");
// Console.WriteLine("Суббота - 6");
// Console.WriteLine("Воскресенье - 7");
int a = Convert.ToInt32(Console.ReadLine());
if ((a > 7) || (a < 1)) { Console.WriteLine($"Вы ввели не верное число {a}, магии не будет!"); }
else if (a == 1) { Console.WriteLine($"{a} не выходной. так как это понедельник"); }
else if (a == 2) { Console.WriteLine($"{a} не выходной. так как это вторник"); }
else if (a == 3) { Console.WriteLine($"{a} не выходной. так как это среда"); }
else if (a == 4) { Console.WriteLine($"{a} не выходной. так как это четверг"); }
else if (a == 5) { Console.WriteLine($"{a} не выходной. так как это пятница"); }
else if (a == 6) { Console.WriteLine($"{a} выходной!!! Это ведь суббота"); }
else if (a == 7) { Console.WriteLine($"{a} выходной!!! Это ведь воскресенье"); }
Console.Write("Всего доброго! Буду рад пообщаться снова! ");