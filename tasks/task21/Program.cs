/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты X, Y и Z первой точки:");
double pointAX = Convert.ToDouble(Console.ReadLine());
double pointAY = Convert.ToDouble(Console.ReadLine());
double pointAZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X и Y второй точки:");
double pointBX = Convert.ToDouble(Console.ReadLine());
double pointBY = Convert.ToDouble(Console.ReadLine());
double pointBZ = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(pointBX - pointAX,2) + Math.Pow(pointBY - pointAY,2) + Math.Pow(pointBZ - pointAZ,2));
Console.WriteLine($"Расстоние между точками = {Math.Round(length,2)}");