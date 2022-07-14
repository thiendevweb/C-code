using System;

namespace Luyencode{
    class Learning{
        static void Main(string[] args){
            System.Console.Write("Nhap so can in: ");
            int number = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap kich thuoc in ra: ");
            int size = Convert.ToInt32(Console.ReadLine());
            // for (int i = size - 1; i >= 0; i--)
            // {
            //     for (int j = 0; j <= i; j++)
            //         System.Console.Write(number + " ");
            //     System.Console.WriteLine();
            // }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                    System.Console.Write(number + " ");
                System.Console.WriteLine();
            }
        }
    }
}