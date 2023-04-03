// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.Write("Enter number X :");
int numX = int.Parse(Console.ReadLine());

System.Console.Write("Enter number Y :");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    System.Console.WriteLine("Section 1");
}
else if (numX < 0 && numY > 0)
{
    System.Console.WriteLine("Section 2");
}
else if (numX < 0 && numY < 0)
{
    System.Console.WriteLine("Section 3");
}
else if (numX > 0 && numY < 0)
{
    System.Console.WriteLine("Section 4");
}
else{
     System.Console.WriteLine("Section 0");
}