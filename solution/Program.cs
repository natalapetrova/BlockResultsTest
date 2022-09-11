// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами

string[] arrayFirst = new string[8] { "hello", "2", "world", ":-)", "1234", "Russia", "yes", "Kazan" };     // Задаем массив
string[] arraySecond = new string[arrayFirst.Length];               // Задаем пустой массив, длина которого равна длине первого массива

void SortingArray(string[] arrayFirst, string[] arraySecond)        // Метод выбирает элементы массива
{
    int count = 0;                                                  // Вводим переменную
    for (int i = 0; i < arrayFirst.Length; i++)                     // Цикл для перебора всех элементов заполненного массива
    {
        if (arrayFirst[i].Length <= 3)                              // Если длина элемента массива меньше 3
        {
            arraySecond[count] = arrayFirst[i];                     // То во второй массив вносим этот элемент
            count++;                                                // Инкремент
        }
    }
}

void PrintResult(string[] array)                                    // Метод печатает результат
{
    Console.Write("[ ");                                            // Печатаем скобку
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{array[i]} ");                              // Печатаем каждый символ по очереди

    }
    Console.Write("]");                                             // Печатаем скобку
}

SortingArray(arrayFirst, arraySecond);                              // Вызываем методы
PrintResult(arraySecond);