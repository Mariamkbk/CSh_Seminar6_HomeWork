// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

int [,]FillAndShowArray(int stroka, int stolbec)
{
    int [,]Array = new int[stroka,stolbec];
    for (int i=0;i<stolbec; i++)
    {
        for (int j=0; j<stroka;j++)
        {
        Array[j,i] = new Random().Next(1,10);
        Console.Write($"{Array[j,i]} ");
        }
        Console.WriteLine();
    }
    return Array;
}
void FindMinMax(int[,]arr)
{
    int min = arr[0,0];
    int max = arr[0,0];
    int minj = 0;
    int mini = 0;
    int maxj = 0;
    int maxi = 0;
    for (int i=0;i<arr.GetLength(1); i++)
    {
        for (int j=0; j<arr.GetLength(0);j++)
        {
            if(arr[j,i]<min) 
            {
                min = arr[j,i];
                minj = j;
                mini = i;
            }
            if(arr[j,i]>max) 
            {
                max = arr[j,i];
                maxj = j;
                maxi = i;
            }
        }
    }
Console.WriteLine($"Минимальное число массива равно: {min}, расположено на {mini+1} строке, в {minj+1} столбце");
        Console.WriteLine($"Максимальное число массива равно: {max}, расположено на {maxi+1} строке, в {maxj+1} столбце");
}

Console.WriteLine("Введите количество строк в таблице");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в таблице");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = FillAndShowArray(m,n);
FindMinMax(arr);