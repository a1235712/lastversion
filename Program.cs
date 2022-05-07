//Задача : Напишите программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых равна меньше или равна три символа
//Перевоначальный массив можно ввести с клавиатуры либо задать
// на старте выполнения алгоритма

string[] arr =                                       //ВВели исхедный массив символов

{
    "bello", "2", "world", ":-)",
    "Russia", "Denmark", "-2",  "1234", "1567",
    "computer  science",
};                                                  

string[] GetValidArray(string[] array)              // Задаем метод формирования массива валидных элементов
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)                   // ПРоверяем в цикле , если количество символлов 1 элемента исходного массива  меньше или равно 3
        {
            count++;                                // Считаем кол-во таких элементов 
        }

    }
    Console.WriteLine();


    string[] ValidArray = new string[count];        // на основвании счетчивка задаем массив строк валидных элеменитов 
    {

        int j = 0;

        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                ValidArray[j++] = array[i];         // Заполняем массив валидных элементов рподходящими элементами исходного массива
            }

        }
        return ValidArray;
    }
}
string PrintArray(string[] array)                   // Создаем универсальный метод для печати массивов
{
    int size = array.Length;
    string print = String.Empty;
    for (int i = 0; i < size; i++)
    {
        print += $"{array[i]}  ";                   
    }

    return print;
}

Console.WriteLine();                                // Печатаем исходный и целевой массив
Console.WriteLine(PrintArray(arr));                 
Console.WriteLine();
string[] valid = (GetValidArray(arr));

Console.WriteLine($"{PrintArray(valid)} ");
Console.WriteLine();

