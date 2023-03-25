// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);
int [] newArray = new int [n*m];
RemakeArray(array, newArray);
PrintArrayNew(newArray);
SortNewArray(newArray);
PrintArrayNew(newArray);
SortDoubleArray(newArray,array);
PrintArray(array);

// PrintArray(array);


void FillArray (int m, int n)
{
    for (int i = 0; i<array.GetLength(0);i++)
        for (int j = 0; j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(0,10);
}
void PrintArray (int [,] array)
{
    Console.WriteLine();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write($"{array[i,j],5} \t");
        Console.WriteLine();
    }
Console.WriteLine();
}

void RemakeArray ( int [,] array, int [] newArray)
{
    int k = 0;
        for (int i=0; i< array.GetLength(0); i++)
            for (int j=0; j<array.GetLength(1); j++)
            {    
                newArray[k] = array[i,j];
                k++;
            }
}

void SortNewArray (int [] newArray)
{
    int temp;
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[i] > newArray[j])
                    {
                        temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }                   
                }            
            }
}

void PrintArrayNew (int [] newArray )
{
    Console.WriteLine();
    
    for (int i=0; i< newArray.GetLength(0); i++)
    {
        Console.Write($"{newArray[i],5} \t");
    // Console.WriteLine();
    }
Console.WriteLine();
}

void SortDoubleArray (int [] newArray, int [,] array)
{
    int k=0;
    while (k<newArray.Length)
    {
        for (int i = 0; i<array.GetLength(0);i++)
        {
            for (int j = 0; j<array.GetLength(1);j++)
            {
                array[i,j]= newArray[k];
                k++;
            }
        }
    }
}
