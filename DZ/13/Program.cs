// Очищаем консоль
Console.Clear();

// Запрашиваем у пользователя число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// Проверяем, что введенное число трехзначное
if (number >= 100)
{
    // Преобразуем число в строку для работы с отдельными символами
    string strNumber = number.ToString();

    // Получаем третий символ (с индексом 2) и преобразуем его в число
    int result = int.Parse(strNumber[2].ToString());

    // Выводим результат
    Console.WriteLine($"Результат равен: {result}");
}
else
{
    // Выводим сообщение об ошибке
    Console.WriteLine("Третьей цифры нет.");
}