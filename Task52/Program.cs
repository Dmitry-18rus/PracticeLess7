// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);
double [] newArray = new double [n];
MiddleArif(array);
PrintArrayNew(newArray);

void FillArray (int m, int n)
{
    for (int i = 0; i<array.GetLength(0);i++)
        for (int j = 0; j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(0,10);
}
void PrintArray (int [,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write($"{array[i,j],5} \t");
        Console.WriteLine();
    }
Console.WriteLine();
}

void MiddleArif ( int [,] array)
{
    int sum1 = 0;
    for (int j=0; j< array.GetLength(1); j++)
    {
        sum1 = 0;
        for (int i=0; i< array.GetLength(0); i++)
            sum1 = array[i,j]+sum1;
            double mid = Math.Round(Convert.ToDouble(sum1)/Convert.ToDouble(m),2);
            newArray[j] = mid;
    }
}

void PrintArrayNew (double [] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        Console.Write($"{array[i],5} \t");
        // Console.WriteLine();
    }
}