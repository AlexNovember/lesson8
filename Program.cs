// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
int[,] Input()
        
        {
            Console.Write("Введите размерность массива (N x M): \nN = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("M = ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            
            int[,] array = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rnd.Next(0, 20);
            return array;
        }
        
        
        void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,5}", array[i, j]);
        }
        void Reverse(int[,] array)
        {
            int Temp;
            for (int k = 0; k < array.GetLength(0); k++)
                for (int i = 0; i < array.GetLength(1) - 1; i++)
                    for (int j = i + 1; j < array.GetLength(1); j++)
                        if (array[k, j] > array[k, i])
                        {
                            Temp = array[k, j];
                            array[k, j] = array[k, i];
                            array[k, i] = Temp;
                        }
 
                    }
 
     
            int[,] arr = Input();
            Console.WriteLine("Исходный массив:");
            printArray(arr);
            Reverse(arr);
            Console.WriteLine("Отсортированный массив:");
            printArray(arr);
            // Console.ReadKey();