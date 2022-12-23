Console.Clear();

Console.WriteLine("Введите номер дня недели!");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 6 || N == 7)
{
    Console.WriteLine("Выходной день!!!");
}
else if (N < 1 || N > 7)
{
    Console.WriteLine("Данное число не соответствует дню недели, введите другое число!");
}
else Console.WriteLine("Этот день не выходной.");
