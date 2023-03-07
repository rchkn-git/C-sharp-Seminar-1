// Однострочный комментарий

/*


Многострочный


*/


// Ещё вариант
// выделяешь строки
// и
// жмёшь ctr + /

/* Задача 1
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int min = n * (-1);
while (min <= n)
{
    Console.Write($"{min} ");
    min++;
}

*/

// На вход принимает трёхзначное число, а на выходе последняя цифра трёхзначного числа

/* Задача 2
Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine()!);
n = n % 10;
Console.WriteLine(n);
*/

/* Задача 3
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = n * n;
Console.WriteLine(n);
*/

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int sqr = Convert.ToInt32(Math.Pow(n, 2));
Console.WriteLine(sqr);

/* Задача 4
Console.WriteLine("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);

switch (n)
{
    case 1:
    Console.WriteLine("О Боже, это понедельник!");
    break;

    case 2:
    Console.WriteLine("Эх, уже вторник, почти дожили...");
    break;

    case 3:
    Console.WriteLine("Среда пришла - неделя прошла!");
    break;

    case 4:
    Console.WriteLine("Брат, уже четверг, очнись!");
    break;
    
    case 5:
    Console.WriteLine("Пятница *_*");
    break;

    case 6:
    Console.WriteLine("Суббота, чиллим)");
    break;

    case 7:
    Console.WriteLine("Воскресенье... а счастье было так близко!");
    break;

    default:
    Console.WriteLine("В неделе нет такого дня!");
    break;
}
*/