// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = GetRandomArray(5);

string str = string.Join(", ", arr);
System.Console.Write("[" + str + "] -> " + GetDiffMaxMin(arr));

int[] GetRandomArray(int length) 
{
    int[] result = new int[length];

    for (int i=0; i<length; i++) 
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

int GetDiffMaxMin(int[] array)
{   
    int min = array[0];  
    int max = 0; 
    int sum = 0;
     
    for(int i = 0; i < array.Length; i++)    
    {       
        if (array[i] < min)
            min = array[i];

        if (array[i] > max)
            max = array[i];

        sum = max - min;       
    }    
    return sum;   
}
