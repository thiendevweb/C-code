// using System;

// namespace CodeVui{
//     class AccFb{
//         private string User;
//         private string Password;
//         public AccFb(){
//             this.User = "";
//             this.Password = "";
//         }
//         public AccFb(string User,string Password){
//             this.User = User;
//             this.Password = Password;
//         }
//         public void setUser(string User){
//             this.User = User;
//         }
//         public void setPass(string Password){
//             this.Password = Password;
//         }
//         public string getUser(){
//             return this.User;
//         }
//         public string getPass(){
//             return this.Password;
//         }
//         public void input(){
//             System.Console.Write("Enter user: ");
//             this.User = Console.ReadLine();
//             System.Console.Write("Enter password: ");
//             this.Password = Console.ReadLine();
//         }
//         public void showinf(){
//             System.Console.WriteLine("User: " + this.User);
//             System.Console.WriteLine("Password: " + this.Password);
//         }
//     }
//     class CheckLo{
//         public static bool checkAcc(string User,string Password,List<AccFb> listAcc){
//             foreach (AccFb i in listAcc)
//             {
//                 if (i.getUser() == User && i.getPass() == Password)
//                     return true;
//             }
//             return false;
//         }
//         static void Main(string[] args){
//             bool flag = true;
//             List<AccFb> listAcc = new List<AccFb>();
//             do
//             {
//                 System.Console.WriteLine("Login system.\n1.Create a new account.(create)\n2.Login.(login)\n3.Exit.(exit)");
//                 string choose = Console.ReadLine();
//                 switch(choose){
//                     case "create":
//                         System.Console.WriteLine("Creat a new account !");
//                         System.Console.Write("Enter user: ");
//                         string tempUser = Console.ReadLine();
//                         System.Console.Write("Enter Password: ");
//                         string tempPass = Console.ReadLine();
//                         listAcc.Add(new AccFb(tempUser,tempPass));
//                         break;  
//                     case "login":
//                         System.Console.Write("Enter user: ");
//                         string lgUser = Console.ReadLine();
//                         System.Console.Write("Enter Password: ");
//                         string lgPass = Console.ReadLine();
//                         if (checkAcc(lgUser,lgPass,listAcc))
//                             System.Console.WriteLine("Login sucessfully!!!");
//                         else 
//                             System.Console.WriteLine("Falled, Your user or password is not correct !\nPlease try again !");
//                         break;  
//                     case "exit":
//                         System.Console.WriteLine("Exit the system !");
//                         flag = false;
//                         break; 
//                     default:
//                         System.Console.WriteLine("Invalid choose,Please choose again !");
//                         break; 
//                 }
//             } while (flag);
//         }
//     }
// }