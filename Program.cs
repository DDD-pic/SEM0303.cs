
    return matrix; // Вернули заполненную табличку
}
//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 
/*int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        // i,j,m,k - индексы
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix; // Вернули заполненную табличку
}

void PrintMatrix(int[,] matr) // Печатаем двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
    {
        for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
        {
            Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
        }
        Console.WriteLine();
    }
}

// 1. Создать массив
int[,] resultMatrix = GetMatrix(3,4,0,10);
// 3 строчки и 4 столбца, числа от 0 до 10 включительно

// 2. Посмотрим на нашу матрицу
PrintMatrix(resultMatrix);
*/
//Задача 48: Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

/*int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        // i,j,m,k - индексы
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
        {
            matrix[i, j] = i + j;
        }
    }
void PrintMatrix(int[,] matr) // Печатаем двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
    {
        for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
        {
            Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
        }
        Console.WriteLine();
    }
}

// 1. Создать массив
int[,] resultMatrix = GetMatrix(3, 4);
// 3 строчки и 4 столбца, числа от 0 до 10 включительно

// 2. Посмотрим на нашу матрицу
PrintMatrix(resultMatrix);
*/
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба 
//индекса чётные, и замените эти элементы на их квадраты.


/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*Console.WriteLine("Задайте количество строк двумерного массива:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int j = Convert.ToInt32(Console.ReadLine());
double[,] GetMatrix( int rows, int cols)
{
   double[,] matrix = new double[ rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        
        for (int j = 0; j < cols; j++)
        {
            Random random = new Random();
            
             matrix[i, j] = new Random().Next(-10, 10) /-+10.0;
        }
    }
    return matrix; 
}

void PrintMatrix(double[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int m = 0; m < matr.GetLength(1); m++) 
        {
            Console.Write(matr[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}    
double[,] resultMatrix = GetMatrix(3, 4);


PrintMatrix(resultMatrix);
 
Console.WriteLine();
*/



//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1(строчка) 7 (столбец) -> такого числа в массиве нет
/*
Console.WriteLine("Задайте количество строк двумерного массива:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int j = Convert.ToInt32(Console.ReadLine());
int[,] GetMatrix( int rows, int cols)
{
   int[,] matrix = new int[ rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        
        for (int j = 0; j < cols; j++)
        {
            Random random = new Random();
            
             matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix; 
}

void PrintMatrix(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int m = 0; m < matr.GetLength(1); m++) 
        {
            Console.Write(matr[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}    
int[,] resultMatrix = GetMatrix(3, 4);



  if (0 > i && 0 < j) 
  {
  Console.WriteLine($"этого элемента");
   }

   else 
   {
   Console.WriteLine($"{i}{j} -> такого числа в массиве нет");
   }
   
PrintMatrix(resultMatrix);
 
Console.WriteLine();
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите 
//среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

  Console.WriteLine("Задайте количество строк двумерного массива:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int j = Convert.ToInt32(Console.ReadLine());
int[,] GetMatrix( int rows, int cols)
{
   int[,] matrix = new int[ rows, cols]; 
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++)
        {
            Random random = new Random();
            
             matrix[i, j] = new Random().Next(1,9);
        }
    }
    return matrix; 
}

void PrintMatrix(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int m = 0; m < matr.GetLength(1); m++) 
        {
            Console.Write(matr[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}    
int[,] resultMatrix = GetMatrix(3,4);

PrintMatrix(resultMatrix);
 
Console.WriteLine();
MyMatrix(resultMatrix);
void MyMatrix(int[,]arMatrix) 
{
    
    for (int i = 0; i < arMatrix.GetLength(1); i++) 
    {
        double sum = 0;
        for (int j = 0; j < arMatrix.GetLength(0); j++) 
        {
            sum += arMatrix[j,i];
        }    
        
         
        Console.WriteLine($"Средарифм. столбца: {i} = {sum/arMatrix.GetLength(0)}");
    }     
    
}   






 
    
  


