// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

double sum1 = 0;
for (int i = 0; i < 5; i++)
{
   
  {
    sum1 += matrix[0, i];
  }
}

  double Mean1 = Math.Round(sum1 / 5, 2);

double sum2 = 0;
for (int i = 0; i < 5; i++)
{
   
  {
    sum2 += matrix[1, i];
  }
}

  double Mean2 = Math.Round(sum2 / 5, 2);

double sum3 = 0;
for (int i = 0; i < 5; i++)
{
   
  {
    sum3 += matrix[2, i];
  }
}

  double Mean3 = Math.Round(sum3 / 5, 2);

  Console.WriteLine($"Среднее арифметическое каждого столбца: {Mean1}; {Mean2}; {Mean3}");