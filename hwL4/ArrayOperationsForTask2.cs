// static class ArrOperation
//     {

//         public static int PairedWayTask2(int[] arr, int way)
//         {
//             int sum = 0;

//             for (int i = 1; i < arr.Length; i++)
//             {
//                 if (arr[i] % way == 0 && arr[i - 1] % way != 0)
//                     sum++;
//                 else if (arr[i - 1] % way == 0 && arr[i] % way != 0)
//                     sum++;
//             }
//             return sum;

//         }
//         public static void Method2(int[] arr, int from, int to)
//         {
//             Random random = new();
//             for (int i = 0; i < arr.Length; i++)
//                 arr[i] = random.Next(from, to);
//         }

//         public static int[,] ArrayOperations(string path)
//         {
//             bool flag = false;
//             do
//             {
//                 try
//                 {
//                     flag = false;
//                     File.ReadAllLines(path);

//                 }
//                 catch
//                 {
//                     Console.WriteLine("Такого файла нет, введите корректный путь до файла: ");
//                     path = Console.ReadLine();

//                 }
//             } while (flag);

//             string[] lineArr = File.ReadAllLines(path);
//             int[,] storage = new int[0, 0];
//             int row = lineArr.Length;
//             int col = -1;
//             for (int i = 0; i < lineArr.Length; i++)
//             {
//                 string[] line = lineArr[i].Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
//                 if (col == -1)
//                 {
//                     col = line.Length;
//                     storage = new int[row, col];
//                 }

//                 for (int j = 0; j < line.Length; j++)
//                 {
//                     storage[i, j] = Int32.Parse(line[j]);
//                 }
//             }
//             return storage;
//         }

//         public static void Print(int[,] arr)
//         {
//             int row = arr.GetLength(0);
//             int col = arr.GetLength(1);
//             for (int i = 0; i < row; i++)
//             {
//                 for (int j = 0; j < col; j++)
//                 {
//                     Console.Write($"{arr[i, j],3} ");
//                 }
//                 Console.WriteLine();

//             }
//         }
//     }
// }
