// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);
Find(array);


void FillArray (int m, int n)
{
    for (int i = 0; i<array.GetLength(0);i++)
        for (int j = 0; j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(0,100);
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

void Find (int [,] array)
{
    Console.WriteLine("Введите число поиска ");
    int nFind = Convert.ToInt32(Console.ReadLine());
    bool resultFind =false;
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            if (array[i,j]==nFind)
            {
                resultFind = true;
                Console.Write($"число {nFind} стоит на перечении стоки {i+1} и столбца {j+1}");
            }
        }
    }

    if (resultFind == false) {Console.WriteLine("Такого элемента в массиве нет");
}
}