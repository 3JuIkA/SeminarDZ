int a = 1;
bool not = true;

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (a <= num)
{
    if (a % 2 != 1)
    {
        Console.WriteLine(a + ", ");
        not = false;
    }
    a++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел");
}