// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] startMass = { "Peter", "332", "each", "--1", "0", "Kerrigan", "Pencil", "424" };
string[] outMass = new string[0];

for (int i = 0; i < startMass.Length; i++)
{
    if (startMass[i].Length <= 3)
    {
        Array.Resize(ref outMass, outMass.Length + 1);
        outMass[outMass.Length-1] = startMass[i];
    }
}

//foreach (string item in outMass) Console.WriteLine($"{item} ");