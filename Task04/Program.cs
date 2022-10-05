Console.WriteLine("Введите трехзначное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN >= 100 && numberN <= 999)
{
    int lastDigit = numberN % 10;
    Console.Write($"Последняя цифра числа: {lastDigit}");
}
else Console.Write("Число не трехзначное");
