// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Enter number : ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

int sqr = num * num;

Console.WriteLine($"sqr = {sqr}");


//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
sqr = Convert.ToInt32(Math.Pow(numberB, 2));
if (sqr == numberA)
{
    Console.WriteLine("A является квадратом B");
}
else
{
    Console.WriteLine("A не является квадратом B");
}


//Напишите программу, 
//которая будет выдавать название дня недели по заданному номеру.

Console.Clear();

Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Среда");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введен неправильный номер");
}


switch (numberDayOfWeek)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Введен неправильный номер"); break;

}


//Задача с двумя друзьями и собакой 

int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;



while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine($"Количество раз, за которое собака пробежит, равно - {count}");