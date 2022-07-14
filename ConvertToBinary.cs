// using System;

// namespace convertTo{
//     class convertBi{
//         static void Main(string[] args){
//             System.Console.Write("Nhap so thap phan: ");
//             int DecimalInput = Convert.ToInt32(Console.ReadLine());
//             int result = 0;
//             int count = 0;
//             while (DecimalInput > 0)
//             {
//                 int temp = DecimalInput % 2;
//                 result = result * 10 + temp;
//                 count++;
//                 DecimalInput = DecimalInput / 2;
//             }
//             System.Console.WriteLine(count);
//             for (int i = 0; i < count; i++)
//             {
//                 System.Console.Write(result % 10);   
//                 result = result / 10;
//             }
//             // System.Console.Write("Nhap so thap phan: ");
//             // string DecimalInput = Console.ReadLine();
//             // string result = "";;
//             // int num = Convert.ToInt32(DecimalInput);
//             // while (num > 0)
//             // {
//             //     int remainder = num % 2;
//             //     result = Convert.ToString(remainder) + result;
//             //     num /= 2;
//             // }
//             // System.Console.WriteLine(result);
//         }
//     }
// }