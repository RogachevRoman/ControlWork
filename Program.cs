// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

void PrintStringArray(string[] stringArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}
int StringsWithSize3(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
             numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] CreateArrayWithSize3(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
         if (stringArray[i].Length <= 3)
        {
             newStringArray[j] = stringArray[i];
             j++;
        }
    }
    return newStringArray;
}

string[] stringArray = {"1234", "1567", "-2", "computer science", "hello", "2", "world", ":-)"};
PrintStringArray(stringArray);

int sizeNewArray = StringsWithSize3(stringArray);
string[] newStringArray = CreateArrayWithSize3(stringArray, sizeNewArray);
Write(" => ");
PrintStringArray(newStringArray);
WriteLine();