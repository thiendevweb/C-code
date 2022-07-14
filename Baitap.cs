// using System;

// namespace Learning{
//     class study{
//         static void Main(string[] args){
//             //Bai 1
//             System.Console.WriteLine("Bai 1");
//             System.Console.Write("Nhap a: ");
//             int a = Convert.ToInt32(System.Console.ReadLine());
//             System.Console.Write("Nhap b: ");
//             int b = Convert.ToInt32(System.Console.ReadLine());
//             System.Console.WriteLine("Tong: " + (a + b) + "\nHieu: " + (a - b) + "\nTich: " + (a*b)+"\nThuong: " + (a/b));
//             //Bai 2
//             System.Console.WriteLine("Bai 2");
//             System.Console.Write("Nhap canh a: ");
//             int a2 = Convert.ToInt32(System.Console.ReadLine())            ;
//             System.Console.Write("Nhap canh b: ");
//             int b2 = Convert.ToInt32(System.Console.ReadLine());
//             System.Console.WriteLine("Chu vi: " + 2*(a2 + b2) + "\nDien tich: " + (a2*b2));
//             //Bai 3
//             System.Console.WriteLine("Bai 3");
//             System.Console.Write("Nhap ban kinh: ");            
//             double r = Convert.ToDouble(System.Console.ReadLine());
//             System.Console.WriteLine("Chu vi: " + (2*Math.PI*r) + "\nDien tich: " + (Math.PI*Math.Pow(r,2)));
//             //Bai 4
//             System.Console.WriteLine("Bai 4");
//             System.Console.Write("Nhap so ngay cong: ");
//             int day = Convert.ToInt32(System.Console.ReadLine());
//             System.Console.Write("Nhap bac tho: ");
//             int step = Convert.ToInt32(System.Console.ReadLine());
//             switch(step){
//                 case 1:
//                     System.Console.WriteLine("Luong thang: " + (150000*day));
//                     break;
//                 case 2:
//                     System.Console.WriteLine("Luong thang: " + (300000*day));
//                     break;
//                 default:
//                     System.Console.WriteLine("Nhap khong hop le !");
//                     break;
//             }
//         }
//     }
// }