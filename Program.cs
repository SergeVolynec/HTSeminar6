// Console.Write("Сколько будет вводиться цифр: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"Введите {i+1}-е число: ");
//     array [i] = Convert.ToInt32(Console.ReadLine());
// }

// int CountPositive (int [] arr)
// {
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     if (arr[i]>0) count++;
// }
// return count;
// }
// Console.WriteLine ($"Чисел больше 0: {CountPositive(array)}");



// Console.Write("Введите коэффициент b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коэффициент k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коэффициент b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите коэффициент k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// void CrossPoint(double b1, double k1, double b2, double k2)
// {
//     if (k2 != k1)
//     {
//         double x = Math.Round((b1 - b2) / (k2 - k1), 2);
//         double y = Math.Round((k1 * (b1 - b2) / (k2 - k1) + b1), 2);
//         Console.Write($"Точка пересечения: ({x};{y})");
//     }
//     else Console.Write("Деление на 0");
// }

// CrossPoint(b1, k1, b2, k2);

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

string arr = "";
while (n / 2 > 0)
{
    arr = arr + n  % 2;
    n = n / 2;
}

char[] sReverse = arr.ToCharArray();
Array.Reverse(sReverse);
string final = "1" + new string(sReverse);
Console.WriteLine (final);