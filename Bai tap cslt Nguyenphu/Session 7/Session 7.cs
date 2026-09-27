using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bai_tap_cslt_Nguyenphu.Session_7
{
    internal class Session_7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /*Console.Write("input n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            TaoMangRandom(arr);
            InMang(arr);
            //Bai 1
            /*Console.Write($"Trung Binh Array la: {TinhTrungBinhArray(arr)}");*/

            //Bai 2
            /*Console.Write("Nhap so can tim: ");
            int value = int.Parse(Console.ReadLine());
            if (TestArrayValue(arr, value) == true)
            {
                Console.Write("Value co trong array");
            }
            if (TestArrayValue(arr, value) == false)
            {
                Console.Write("Value khong co trong array");
            }*/
            //Bubble sort
            int[] numbers = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(numbers);

            Console.Write("Nhập vào một câu bất kỳ: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập từ cần tìm: ");
            string targetWord = Console.ReadLine();
            TimTu(sentence, targetWord);

            /*Console.Write("Nhập số hàng N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine());

            // 1. Tạo ma trận ngẫu nhiên
            int[,] matrix = CreateRandomMatrix(n, m);

            // 2. In ma trận
            Console.WriteLine("\n--- MA TRẬN BAN ĐẦU ---");
            PrintMatrix(matrix);

            // 3. In hàng và cột thứ i
            Console.Write($"\nNhập chỉ số i để in hàng/cột (0 đến {Math.Max(n, m) - 1}): ");
            int index = int.Parse(Console.ReadLine());
            PrintRowAndColumn(matrix, index);

            // 4. Tìm giá trị lớn nhất của ma trận
            Console.WriteLine($"\nGiá trị lớn nhất trong ma trận: {FindMaxMatrix(matrix)}");

            // 5. Tìm giá trị nhỏ nhất trên hàng i và cột i
            FindMinInRowAndCol(matrix, index);

            // 6. Chuyển vị ma trận (Transpose)
            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ (Transpose) ---");
            int[,] transposed = TransposeMatrix(matrix);
            PrintMatrix(transposed);

            // 7. In đường chéo chính và đường chéo phụ (chỉ áp dụng nếu là ma trận vuông)
            PrintDiagonals(matrix);*/
        }
        public static int[] TaoMangRandom(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 100);
            }
            return arr;
        }
        public static void InMang(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

        }
        
        public static float TinhTrungBinhArray(int[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (sum / arr.Length);

        }
        public static bool TestArrayValue(int[] arr, int value)
        {
            foreach (int i in arr)
            {
                if (value == i)
                { return true; }

            }
            return false;
        }
        // 4. Xóa một phần tử cụ thể khỏi mảng
        public static int[] RemoveElement(int[] arr, int target)
        {
            int index = Array.IndexOf(arr, target);
            if (index == -1) return arr; 

            int[] result = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    result[j++] = arr[i];
                }
            }
            return result;
        }

        // 5. Tìm giá trị Lớn nhất (Max) và Nhỏ nhất (Min)
        public static (int Min, int Max) FindMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            return (min, max);
        }

        // 6. Đảo ngược mảng số nguyên (In-place)
        public static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        // 7. Tìm các giá trị bị trùng lặp trong mảng
        public static List<int> FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int item in arr)
            {
                if (!seen.Add(item))
                {
                    duplicates.Add(item);
                }
            }
            return duplicates.ToList();
        }

        // 8. Loại bỏ các phần tử trùng lặp khỏi mảng
        public static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueSet = new HashSet<int>(arr);
            int[] result = new int[uniqueSet.Count];
            uniqueSet.CopyTo(result);
            return result;
        }

        public static void BubbleSort(int[] numbers)
        {


            // Thuật toán Bubble Sort
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Hoán đổi 2 phần tử
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nMảng sau khi sắp xếp tăng dần (Bubble Sort):");
            Console.WriteLine(string.Join(", ", numbers));
        }


            public static void TimTu(string sentence, string targetWord)
            {
               

                // Tách câu thành mảng các từ
                char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ';', ':' };
                string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                // Thuật toán Linear Search (Tìm kiếm tuyến tính)
                bool found = false;
                int position = -1;

                for (int i = 0; i < words.Length; i++)
                {
                    if (string.Equals(words[i], targetWord, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        position = i;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine($"\nTừ '{targetWord}'  xuất hiện trong câu tại vị trí từ thứ {position + 1}.");
                }
                else
                {
                    Console.WriteLine($"\nTừ '{targetWord}' KHÔNG xuất hiện trong câu.");
                }
            }

        // 1. Khởi tạo ma trận ngẫu nhiên
        public static int[,] CreateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 100); // Giá trị từ 1 đến 99
                }
            }
            return matrix;
        }

        // 2. In ma trận
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        // 3. In hàng i và cột i
        public static void PrintRowAndColumn(int[,] matrix, int i)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (i >= 0 && i < rows)
            {
                Console.Write($"Hàng {i}: ");
                for (int j = 0; j < cols; j++) Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Hàng {i} nằm ngoài phạm vi.");
            }

            if (i >= 0 && i < cols)
            {
                Console.Write($"Cột {i}: ");
                for (int r = 0; r < rows; r++) Console.WriteLine($"{matrix[r, i]} ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Cột {i} nằm ngoài phạm vi.");
            }
        }

        // 4. Tìm giá trị Max của toàn ma trận
        public static int FindMaxMatrix(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int val in matrix)
            {
                if (val > max) max = val;
            }
            return max;
        }

        // 5. Tìm giá trị Min của hàng i và cột i
        static void FindMinInRowAndCol(int[,] matrix, int index)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (index >= 0 && index < rows)
            {
                int minRow = matrix[index, 0];
                for (int j = 1; j < cols; j++)
                    if (matrix[index, j] < minRow) minRow = matrix[index, j];
                Console.WriteLine($"Min trên hàng {index}: {minRow}");
            }

            if (index >= 0 && index < cols)
            {
                int minCol = matrix[0, index];
                for (int r = 1; r < rows; r++)
                    if (matrix[r, index] < minCol) minCol = matrix[r, index];
                Console.WriteLine($"Min trên cột {index}: {minCol}");
            }
        }

        // 6. Chuyển vị ma trận N x M thành M x N
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        // 7. In đường chéo chính và phụ (Ma trận vuông)
        static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("\n[Thông báo] Không thể in đường chéo vì đây không phải ma trận vuông.");
                return;
            }

            Console.WriteLine("\n--- ĐƯỜNG CHÉO MA TRẬN ---");
            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }

            Console.Write("\nĐường chéo phụ: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, rows - 1 - i]} ");
            }
            Console.WriteLine();
        }
    }
}   
    







