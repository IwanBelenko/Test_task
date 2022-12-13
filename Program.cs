// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

string[] array0 = new string[8] {"Hello", "Russia", "Denmark", "Kazan", "computer since", "2", ";-)", "15"};
string[] array1 = new string[array0.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}], ");
    }
    Console.WriteLine();
}

void ArrayReduction(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

ArrayReduction(array0, array1);
PrintArray(array1);
