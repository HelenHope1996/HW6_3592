/*Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/

//метод, который будет выдавать заполненный массив случайными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,9);
    }

    return array;
}

//метод, который будет печатать массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



// копирование массива 
void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}

int[] firstArr = InitArray(8);
PrintArray(firstArr);

int[] secondArr = InitArray(8);
CopyArray(firstArr, secondArr);
PrintArray(secondArr);

