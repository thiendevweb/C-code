// using System;

// namespace Jump{
//     class Learning{
//         public static int check(int n){
//             if (n < 2)
//                 return 0;
//             for (int i = 2; i <= Math.Sqrt(n); i++)
//             {
//                 if (n % i == 0)
//                     return 0;
//             }
//             return 1;
//         }
//         static void Main(string[] args){
//             // goto printf10;
//             // System.Console.WriteLine("Hello, World !!!");
//             // printf10:
//             // for (int i = 0; i < 10; i++)
//             //     System.Console.WriteLine("Hello Kity !!!");
//             System.Console.Write("Nhap n: ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             if (Learning.check(n) == 1)
//                 System.Console.WriteLine("La so nguyen to !");
//             else
//                 System.Console.WriteLine("Khong la so nguyen to !");
//         }
//     }
// }