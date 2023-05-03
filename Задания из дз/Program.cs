//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.WriteLine ("Input X coordinat of A : ");
int xCoordA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coordinat of A : ");
int yCoordA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coordinat of A : ");
int zCoordA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input X coordinat of B : ");
int xCoordB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coordinat of B : ");
int yCoordB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coordinat of B : ");
int zCoordB= Convert.ToInt32(Console.ReadLine());

int A = (xCoordA-xCoordB);
int B= (yCoordA-yCoordB);
int C= (zCoordA-zCoordB);

double lenght= Math.Sqrt(A*A+ B*B + C*C);
Console.WriteLine($"Line lenght is {lenght}");

/*







//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
Console.Write ("Input your number: ");
int numb_N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numb_N; i++)
{ 
    Console.WriteLine($"{i*i*i} ");
}
*/


//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
Console.WriteLine("Input your number: ");
int n= Convert.ToInt32(Console.ReadLine());
int len= n.Lenght;

if (len == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"{n} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{n} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($" {n} число не пятизначное");
}
 */


