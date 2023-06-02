// Упорядочивание массива


void FillArray(int[] collection)                      // Void - метод которй ничего не возвращает
{                                                     // Метод заполнения мссива рандомными числпми 
    int Length = collection.Length;                   // в диапазоне от 1 до 10.
    for (int index = 0; index < Length; index++)
    {
        collection[index] = new Random().Next(1, 10);
    }
}

// Метод печати массива

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
    Console.WriteLine();
}

//Метод сортировки массива от min до max

void SelectionSortMin(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temparr = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temparr;
    }
}

//Метод сортировки массива от max до min

void SelectionSortMax(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temparr = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temparr;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
SelectionSortMin(array);
PrintArray(array);
SelectionSortMax(array);
PrintArray(array);