// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] arr = GetRandomArray(4);

string str = string.Join(", ", arr);
System.Console.Write("[" + str + "] -> " + FindNum(arr));

int[] GetRandomArray(int length) 
{
    int[] result = new int[length];

    for(int i=0; i < length; i++) 
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int FindNum(int[] array)
{
    int count = 0;   

    for(int i = 0; i < array.Length; i++)    
    {       
        if(array[i] % 2 == 0)                
        count++;             
    }   
    return count;
}
