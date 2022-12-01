// Проверка числа на чётность или нечётность.
Console.WriteLine("Введите ,число" );
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " не является чётным");
}
else
{
    Console.WriteLine("Число " + num + "является чётным");
}