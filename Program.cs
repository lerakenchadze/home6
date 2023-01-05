// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int [] Numbers(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine(count);
// }

// Console.Write ("Enter your numbers: ");
// int array = Convert.ToInt32(Console.ReadLine());

// Numbers(array);






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double [] Tochka(double b1, double b2, double k1, double k2)
{  
    double [] array = new double [2] ;
     array[0] = (b2 - b1) / (k1 -k2); 
     array[0] = (b2 - b1) / (k1 -k2); 
    array[1] = k1* array[0] + b1; 

    return array ;
}

Console.Write ("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
double [] array = Tochka (b1,k1,b2,k2);
Console.WriteLine($"Точки пересечения прямых: X:{Math.Round (array[0],1)} Y:{Math.Round (array[1],1)}");

