// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}
int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
Console.Write ("Укажите номер строки ");
int A = int.Parse (Console.ReadLine());

Console.Write ("Укажите номер столбца ");
int B = int.Parse (Console.ReadLine());

if (A > 3 || B > 4 )
{
Console.WriteLine();
Console.WriteLine("Такого числа в массиве нет");
}
else
Console.WriteLine();
Console.WriteLine(matrix[A,B]);