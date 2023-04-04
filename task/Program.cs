/*Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

using System;
using static System.Console;

Clear();
string [] array = {"hello", "2", "world", ";-)" };
int symbolslimit = 3; //максимальный лимит символов
GetArraySymbolsLimit(array);
PrintArray(GetArraySymbolsLimit(array));


string [] GetArraySymbolsLimit (string [] array)
{
    int length = array.Length;			
	string[] resultArray = new string[length];
	int count = 0;
    
	for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= symbolslimit)
        {
            resultArray[count] = array[i];
            count++;
        }
	}
	Array.Resize(ref resultArray, count);
	return resultArray;
}
		
void PrintArray(string[] array)
{
    if(array.Length == 0)
	{
        WriteLine("Значений не обнаружено");
	}
	else
	{
        Console.WriteLine($"[{String.Join(",", array)}]");
	}
}