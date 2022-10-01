/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []                        */

string[] GetArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CountLessThan(string[] arr) 
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++) 
    {
        if(arr[i].Length <= 3) 
        {
            count++;
        }
    }
    return count;
}    

string[] OutArray (string[] arr) 
{
    string[] outArr = new string[CountLessThan(arr)];

    for(int i = 0, j = 0; i < arr.Length; i++) 
    {
        if(arr[i].Length <= 3) 
        {
            outArr[j] = arr[i];
            j++;
        }
    }
    return outArr;
}

string[] myArray = GetArray();
string[] newArray = OutArray(myArray);
Console.WriteLine($"[{String.Join(", ", myArray)}] -> [{String.Join(", ", newArray)}]");
