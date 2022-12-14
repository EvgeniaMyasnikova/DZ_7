/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)
*/

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

int rows = new Random().Next(3,10);
int columns = new Random().Next(3,10);

int[,] array =  new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
if (m > rows || n > columns) Console.WriteLine("Такого элемента не существует");
else Console.WriteLine($"Значение элемента: {array[m, n]}");





