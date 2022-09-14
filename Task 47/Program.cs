// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear ();

Console.Write ("Введите число m ");
int m = int.Parse (Console.ReadLine());

Console.Write ("Введите число n ");
int n = int.Parse (Console.ReadLine());

double[,] matrix = new double[m, n]; //Инициализация массива

void FillArray(double[,] matr) // Метод наполнения массива
{
 for (int i = 0; i < matr.GetLength(0); i++) // Перебор строк
 {
 for (int j = 0; j < matr.GetLength(1); j++) // Перебор столбцов
 {
 matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; // Рандомно наполлняем вещественными числами
 }
 }
}

void PrintArray(double[,] matr) //Метод для выведения массива на экран построчно
{
 for (int i = 0; i < matr.GetLength(0); i++) // Перебор строк
 {
 for (int j = 0; j < matr.GetLength(1); j++) // Перебор столбцов
 {
 Console.Write($"{matr[i, j]} "); // Вывод числа с указанием позиции по [Номер строки, Номер столбца]
 }
 Console.WriteLine();
 }
}

FillArray(matrix); 
PrintArray(matrix);
