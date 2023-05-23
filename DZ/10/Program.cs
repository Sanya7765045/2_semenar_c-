Console.Clear();
// Очищаем консоль

Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());

if (a >= 100 && a <= 999)
{
    // Вычисляем результат
    int result = (a % 100) / 10;
    Console.WriteLine($"Результат равен: {result}");
}
else
{
    // Число не является трехзначным
    Console.WriteLine("Число не является трехзначным. Пожалуйста, введите трехзначное число.");
}
