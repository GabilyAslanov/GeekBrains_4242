// // Задача 24: Напишите программу, 
// // которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// int SetNumber(string text = "")
// {
//     Console.Write($"Enter number {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int num = SetNumber();
// int sum = 0;
// for (int i = 1; i <= num; ++i)
// {
//     sum += i;
// }

// System.Console.WriteLine("sum = " + sum);

int a = 40;

int b = 30; // b = 40 a = 41
int c = a + b ;
System.Console.WriteLine($"a= {a} b={b}");
 bool Task21()
{
    Console.Write("\nВведите координаты первой точки (разделитель - пробел): ");
    double[] point1 = Console.ReadLine().Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.Write("\nВведите координаты второй точки (разделитель - пробел): ");
    double[] point2 = Console.ReadLine()!.Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.WriteLine($"D = {Math.Sqrt(point1.Zip(point2, (first, second) => Math.Pow(first - second, 2)).Sum())}");
    return true;
}