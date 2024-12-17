using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;


namespace Demo02
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region StringFormatting

            //int x = 3, y = 4;
            //Console.WriteLine("Equation:" +x+" + "+y+" = "+(x+y));

            //Console.WriteLine($"Equation:{x} + {y} = {x+y}");

            //Console.WriteLine(string.Format("Equation:{0} + {1} = {2}",x,y,x+y));

            #endregion
            #region conditionalControlStatment

            //Console.Write("Enter number of month in first quarter: ");


            //int month = int.Parse(Console.ReadLine());

            //if (month == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //if (month == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //if(month == 3) {
            //{
            //    Console.WriteLine("Mar");
            //}


            //if (month == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else {
            //    Console.WriteLine("Invalid month!");
            //}
            //Console.Write("Enter number of month in first quarter: ");

            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2: 
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3: 
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Ivalid month!");
            //        break;
            //}

            //Console.WriteLine("Enter Your Name");
            //string Name = Console.ReadLine();


            //if (Name == "Ahmed" || Name == "ahmed") {
            //    Console.WriteLine("Hi Ahmed");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine("Hi Ali");
            //}
            //else if (Name == "Youssef" || Name == "youssef")
            //{
            //    Console.WriteLine("Hi Youssef");
            //}
            //else
            //{
            //    Console.WriteLine("Hi");
            //}

            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi Ali");
            //        break;
            //    case "Youssef":
            //    case "youssef":
            //        Console.WriteLine("Hi Youssef");
            //        break;
            //    default:
            //        Console.WriteLine("Hello");
            //        break;
            //}
            #endregion
            #region AgeSystem


            //Console.WriteLine("Enter your age");

            //int Age = int.Parse(Console.ReadLine());

            //if (Age > 18)
            //{
            //    Console.WriteLine("Welcome ;)")
            //} else if (Age < 18)
            //{
            //    Console.WriteLine("Bye :(")
            //}
            //else {
            //    Console.WriteLine("Equal");
            //}

            //Console.WriteLine("Enter your age");

            //int Age = int.Parse(Console.ReadLine());
            //switch (Age) {
            //    case > 18: 
            //        Console.WriteLine("Hello there!");

            //        break;
            //    case 18:
            //        Console.WriteLine("Hello");

            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye");

            //        break;

            //        Console.WriteLine("Press any key to exit...");
            //        Console.ReadKey();

            //}
            #endregion
            #region EvaluationOfSwitch

            //object obj = new object();
            //obj = 1;

            //switch (obj)
            //{
            //    case int i when i < 18:
            //        Console.WriteLine("int");
            //        break;
            //    default:
            //        Console.WriteLine("Not an int or condition not met");
            //        break;
            //}
            #endregion
            #region C# 8.0

            //string input = Console.ReadLine();

            //string output = input switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "Option unknown",
            //};
            //Console.WriteLine(output);
            #endregion
            #region C# 9.0 Search Task
            //var person1 = new person { Name = "Ahmed", Age = 8 ,IQ = 120};
            //var person2 = new person { Name = "Sara", Age = 18 };
            //Console.WriteLine(person1.GetAgeGroup());
            //Console.WriteLine(person1.GetIQGroup());

            //Function in the person class there is a return switch statement
            #endregion
            #region forEach && for

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //foreach (int i in arr) { //also works on LinkedLists
            //Console.WriteLine(i);
            //}


            //for (int i = 0; i < arr.Length; i++) { 
            //    Console.WriteLine(arr[i]);
            //}

            #endregion
            #region While &&  doWhile
            //int i = 1;

            //while (i <= 4)
            //{
            //    Console.WriteLine("Hello\n"+ i);
            //    i++;
            //}

            //int z = 1;
            //do
            //{
            //    Console.WriteLine("Hello \n" + z); 
            //    z++;                              
            //} while (z <= 4);

            #endregion
            #region String

            //string s = new string("Name");
            //string l = "NAme";

            #endregion
            #region StringBuilder

            //StringBuilder Name = new StringBuilder("Namee");
            //Console.WriteLine(Name.GetHashCode());
            ////changing the string is mutable
            //Name.Append("Name");
            //Console.WriteLine(Name);
            //Console.WriteLine(Name.GetHashCode());
            #endregion
            #region String

            //string one = "Car";
            //one.Replace("C", "A");
            //one.ToCharArray();
            //one.CompareTo("Aar");
            //Console.WriteLine(one.CompareTo("Aar"));
            #endregion

        }
    }
}
