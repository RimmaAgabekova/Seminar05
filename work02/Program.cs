// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(4);

string str = string.Join(", ", arr);
System.Console.Write("[" + str + "] -> " + GetSum(arr));

int[] GetRandomArray(int length) 
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-10, 100);
    }
    return result;
}

int GetSum(int[] array)
{   
    int sum = 0; 

    for(int i = 0; i < array.Length; i++)    
    {       
        if(i % 2 == 1)
        sum += array[i];        
    }    
    return sum;   
}
