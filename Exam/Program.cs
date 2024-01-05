/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] ConverStringToArray(string sourceArray)
{
    string[] stringArray = sourceArray.Split(' ');
    return stringArray;
}

//put all array elements that are less than the required limit into a new array

string[] ArrayWhithElemLessThenLimiter(string[] arr, int maxElemLenhgt)
{
    int newArrLength = CountArrayElemesWithLengthLessThanLimiter(arr, maxElemLenhgt);
    string[] newArray = new string[newArrLength];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxElemLenhgt)
        {
            newArray[count++] = arr[i];
        }
    }

    return newArray;
}

//count all array elements that are less than the required limit 

int CountArrayElemesWithLengthLessThanLimiter(string[] arr, int maxElemLenhgt)
{
    int result = 0;
    foreach (string item in arr)
    {
        if (item.Length <= maxElemLenhgt)
        {
            result++;
        }
    }
    return result;
}

string PrintArray(string[] arr)
{
    string arrLine = "";

    for (int i = 0; i < arr.Length; i++)
    {
        arrLine += $"{arr[i]},";
    }

    //remove last comma

    if (arrLine != "")
    {
        arrLine = arrLine.Remove(arrLine.Length - 1);
    }

    return arrLine;
}

Console.WriteLine("Введите строки через пробел: ");

string line = Console.ReadLine();
int lineLimiter = 3;

if (line == "")
{
    Console.WriteLine("Вы не ввели даннные!!!");
    return;
}

string[] sourceArray = ConverStringToArray(line);
string[] resultArray = ArrayWhithElemLessThenLimiter(sourceArray, lineLimiter);

Console.WriteLine($"[{PrintArray(sourceArray)}] -> [{PrintArray(resultArray)}]");

