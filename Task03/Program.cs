Console.WriteLine("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все целые числа в промежутке от {-numberN} до {numberN}: ");

int counter = -numberN;
while (counter <= numberN)
{
    Console.Write($"{counter} ");
    counter++;
}