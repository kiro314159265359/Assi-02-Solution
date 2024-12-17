using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assi_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //long input;
            //Console.Write("Enter a number: ");
            //while (!long.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.Write("Enter a number again: ");
            //}
            //if (input % 3 == 0 || input % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region Q2

            //long input;
            //Console.Write("Enter a number: ");
            //while (!long.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.Write("Enter a number again: ");
            //}
            //if (input < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else if (input > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}

            #endregion
            #region Q3

            //long Var01, Var02 ,Var03;
            //Console.Write("Enter the first Variable : ");
            //while (!long.TryParse(Console.ReadLine(), out Var01))
            //{
            //    Console.Write("Enter first Variable again: ");
            //}
            //Console.Write("Enter the second Variable : ");
            //while (!long.TryParse(Console.ReadLine(), out Var02))
            //{
            //    Console.Write("Enter second Variable again: ");
            //}
            //Console.Write("Enter the third Variable : ");
            //while (!long.TryParse(Console.ReadLine(), out Var03))
            //{
            //    Console.Write("Enter third Variable again: ");
            //}

            //Console.WriteLine($"max element = {Math.Max(Var01, Math.Max(Var02, Var03))}");

            //Console.WriteLine($"min element = {long.Min(Var01, long.Min(Var02, Var03))}");
            #endregion
            #region Q4

            //long input;

            //Console.Write("Enter a Number: ");
            //while (!long.TryParse(Console.ReadLine(),out input) || input < 0) {
            //    Console.Write("Enter a Number: ");
            //}

            //if (input % 2 == 0) {
            //    Console.Write("Even Number");
            //}
            //if (input % 2 != 0)
            //{
            //    Console.Write("Odd Number");
            //}
            #endregion
            #region Q5

            //char[] chars = { 'a', 'e', 'i', 'o', 'u' };

            //char input;

            //Console.Write("Enter a letter : ");
            //while (!char.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.Write("Enter a letter again: ");
            //}
            //string Answer = "Consonant";
            //foreach (char i in chars) {
            //     Answer = "Consonant";
            //    if (i == char.ToLower(input))
            //    {
            //        Answer = "vowel";
            //        break;
            //    }

            //}
            //Console.WriteLine(Answer);

            //OR we can use switch

            //char[] chars = { 'a', 'e', 'i', 'o', 'u' };

            //char input;
            //Console.Write("Enter a letter : ");
            //while (!char.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.Write("Enter a letter again: ");
            //}
            //switch (input) { 
            //case 'a':
            //case 'A':
            //        Console.Write("vowel");
            //        break;
            //case 'e':
            //case 'E':
            //        Console.Write("vowel");
            //        break;
            //case 'i':
            //case 'I':
            //        Console.Write("vowel");
            //        break;
            //case 'o':
            //case 'O':
            //        Console.Write("vowel");
            //        break;
            //case 'u':
            //case 'U':
            //        Console.Write("vowel");
            //        break;
            //default:
            //        Console.Write("Consonant");
            //        break;
            //}


            #endregion
            #region Q6

            //int input;
            //Console.Write("Enter a number: ");
            //while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
            //{
            //    Console.Write("Enter a number again: ");
            //}
            //int number = 1;
            //while (number <= input)
            //{
            //    if (number == input)
            //    {
            //        Console.Write(number);
            //        break;
            //    }
            //    Console.Write(number + ", ");
            //    number++;
            //}
            #endregion
            #region Q7

            //int input;
            //Console.Write("Enter a number: ");
            //while (!int.TryParse(Console.ReadLine(), out input ) || input < 0)
            //{
            //    Console.Write("Enter a number again: ");
            //}

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(input * i + " ");
            //}
            #endregion
            #region Q8

            //int input;
            //Console.Write("Enter a number: ");
            //while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
            //{
            //    Console.Write("Enter a number again: ");
            //}

            //for (int i = 1; i <= input; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion
            #region Q9

            //int number,power,answer=1;
            //Console.Write("Enter a number: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Enter a number again: ");
            //}
            //Console.Write("Enter the Power: ");
            //while (!int.TryParse(Console.ReadLine(), out power) || power < 0)
            //{
            //    Console.Write("Enter a power again can't be negative: ");

            //}
            //for (int i = 1; i <= power; i++) {
            //    answer *= number; 
            //}
            //Console.WriteLine(answer);
            #endregion
            #region Q10

            //int[] Subjects = new int[5];
            //int Total = 0, TotalScore = 500;
            //double Avg = 0, Percent = 0;
            //int i = 0;
            //bool flag = true;
            //while (i < Subjects.Length)
            //{
            //     flag = int.TryParse(Console.ReadLine(), out Subjects[i]);
            //     i++;
            //    if (!flag)
            //    {
            //        Console.WriteLine("Invalid input!");
            //        break;
            //    }

            //}
            //    for (int x = 0; x < Subjects.Length; x++)
            //    {
            //        Total += Subjects[x];

            //}

            //Avg = Total / Subjects.Length;
            //Percent = (Total / (double)TotalScore)*100;

            //Console.WriteLine(Total+ " "+ Avg +" "+ Percent);

            #endregion
            #region Q11

            // int input;
            // Console.Write("Enter a number: ");
            // while (!int.TryParse(Console.ReadLine(), out input))
            // {
            //     Console.Write("Enter a number again: ");
            // }

            //Console.WriteLine($"Days in month {input} are {DateTime.DaysInMonth(2024, input)} days");
            #endregion
            #region Q12
            // 3 + 4
            // 3 - 4
            // 3 * 4
            // 3 ÷ 4
            //string Qustion = Console.ReadLine();

            //char[] CharsOfNumbersEx = Qustion.ToCharArray();
            //char[] CharsOfNumbers = new char[Qustion.Length];
            //int j = 0;
            //for (int i = 0; i < CharsOfNumbersEx.Length; i++)
            //{
            //    if (CharsOfNumbersEx[i] == ' ')
            //    {
            //        continue;
            //    }
            //    CharsOfNumbers[j] = CharsOfNumbersEx[i];
            //    j++;

            //}
            //string ans = "";
            //for (int i = 0; i < CharsOfNumbers.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {

            //        switch (CharsOfNumbers[i])
            //        {
            //            case '+':
            //                double Var01 = (double)Char.GetNumericValue(CharsOfNumbers[i - 1]);
            //                double Var02 = (double)Char.GetNumericValue(CharsOfNumbers[i + 1]);
            //                double Var03 = Var01 + Var02;
            //                ans += $"{Var03}";

            //                break;
            //            case '-':
            //                Var01 = (double)Char.GetNumericValue(CharsOfNumbers[i - 1]);
            //                Var02 = (double)Char.GetNumericValue(CharsOfNumbers[i + 1]);
            //                Var03 = Var01 - Var02;

            //                ans += $"{Var03}";
            //                break;
            //            case '*':
            //                Var01 = (double)Char.GetNumericValue(CharsOfNumbers[i - 1]);
            //                Var02 = (double)Char.GetNumericValue(CharsOfNumbers[i + 1]);
            //                Var03 = Var01 * Var02;
            //                ans += $"{Var03}";
            //                break;
            //            case '÷':
            //                Var01 = (double)Char.GetNumericValue(CharsOfNumbers[i - 1]);
            //                Var02 = (double)Char.GetNumericValue(CharsOfNumbers[i + 1]);
            //                if (Var02 == 0)
            //                {
            //                    Console.WriteLine("Error Can't devide by zero");
            //                    break;
            //                }

            //                Var03 = Var01 / Var02;
            //                ans += $"{Var03}";
            //                break;

            //        }
            //    }


            //}
            //Console.WriteLine(ans);

            //OR

            //double firstNum, secNumber;
            //Console.Write("Enter first Number: ");
            //while (!double.TryParse(Console.ReadLine(), out firstNum))
            //{
            //    Console.Write("Try again: ");
            //}
            //Console.Write("Enter operand: ");
            //string operand = Console.ReadLine();
            //Console.Write("Enter Secound Number: ");
            //while (!double.TryParse(Console.ReadLine(), out secNumber))
            //{
            //        Console.Write("Try again: ");
            //}

            //switch (operand) {
            //    case "+":
            //        Console.WriteLine($"The answer is {firstNum+secNumber}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"The answer is {firstNum - secNumber}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"The answer is {firstNum * secNumber}");
            //        break;
            //    case "÷":
            //        Console.WriteLine($"The answer is {firstNum / secNumber}");
            //        break;
            //}
            #endregion
            #region Q13

            //string input = Console.ReadLine();
            //int i = input.Length - 1;

            //while (i >= 0)
            //{
            //    Console.Write(input[i]);
            //    i--;
            //}

            #endregion
            #region Q14

            //bool flag = int.TryParse(Console.ReadLine(), out int i);

            //if (!flag)
            //{
            //    Console.WriteLine("Error Parsing pass Number only!");
            //    return;
            //}

            //string input = "", output = "";
            //input += i.ToString();


            //int j = input.Length-1;

            //while (j >= 0)
            //{
            //    output += input[j];
            //    j--;
            //}

            //Console.WriteLine(output);

            #endregion
            #region Q15

            //int min, max;
            //while (!int.TryParse(Console.ReadLine(), out min))
            //{
            //    Console.Write("Enter a number again:");
            //}

            //while (!int.TryParse(Console.ReadLine(), out max))
            //{
            //    Console.Write("Enter a number again:");
            //}

            //for (int i = min; i <= max; i++)
            //{
            //    int divisionCount = 0;

            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            divisionCount++;
            //        }
            //    }
            //    if (divisionCount != 2)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            #endregion
            #region Q16
            //decimal input;
            //Console.Write("Enter a number: ");
            //while (!decimal.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.Write("Enter a number again: ");
            //}
            //string answer = input.ToString();
            //string result = Convert.ToString(Convert.ToInt32(answer, 10), 2);
            //Console.WriteLine($"the Binary of {answer} is {result}");
            #endregion
            #region Q17

            //int Xpoint1, Ypoint1;
            //int Xpoint2, Ypoint2;
            //int Xpoint3, Ypoint3;

            //Point pointA = new Point();
            //Point pointB = new Point();
            //Point pointC = new Point();
            //Console.WriteLine("Enter a the x and y of point 1 ");
            //while (!int.TryParse(Console.ReadLine(), out Xpoint1) || !int.TryParse(Console.ReadLine(), out Ypoint1))
            //{
            //    Console.WriteLine("Enter a number again: ");
            //}

            //Console.WriteLine("Enter a the x and y of point 2 ");
            //while (!int.TryParse(Console.ReadLine(), out Xpoint2)|| !int.TryParse(Console.ReadLine(), out Ypoint2))
            //{
            //    Console.WriteLine("Enter a number again: ");
            //}

            //Console.WriteLine("Enter a the x and y of point 3 ");
            //while (!int.TryParse(Console.ReadLine(), out Xpoint3)|| !int.TryParse(Console.ReadLine(), out Ypoint3))
            //{
            //    Console.WriteLine("Enter a number again: ");
            //}
            //// we need to calc area triangle to get if the are on the same line of not 
            ////1/2 |x1(y2 - y3) + x2 (y3-y1) + x3(y1-y2)|
            //pointA.X_Axis = Xpoint1;
            //pointA.Y_Axis = Ypoint1;
            //pointB.X_Axis = Xpoint2;
            //pointB.Y_Axis = Ypoint2;
            //pointC.X_Axis = Xpoint3;
            //pointC.Y_Axis = Ypoint3;

            //double Area = 0.5 * Math.Abs(pointA.X_Axis * (pointB.Y_Axis - pointC.Y_Axis) + pointB.X_Axis * (pointC.Y_Axis - pointA.Y_Axis) + pointC.X_Axis * (pointA.Y_Axis - pointB.Y_Axis));


            //Console.WriteLine(Area == 0 ? "on a single straight line" : "not on a single straight line");


            #endregion
            #region Q18

            Person P01 = new Person();
            //I added a func called GetWorkingHours in the person class at the end
            //from the medium doc
            double Working_Hour;
            string Name = Console.ReadLine();

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Not a Valid Name");
                return;
            }

            Console.WriteLine("Enter how long it took to finish a project");
            while (!double.TryParse(Console.ReadLine(), out Working_Hour))
            {
                Console.WriteLine("Enter a number again: ");
            }

            P01.WorkingHours = Working_Hour;
            P01.Name = Name;

            Console.WriteLine(Person.GetWorkingHour(P01));

        }
    }
}
#endregion
            #region Functions


            public class Point
                    {
                        public int X_Axis { get; set; }
                        public int Y_Axis { get; set; }

                    }

                    public class Person
                    {
                        public string Name { get; set; }
                        public double WorkingHours { get; set; }

                        public static string GetWorkingHour(Person person) =>
                       person switch
                       {
                           { WorkingHours: <= 2 } => $"{person.Name}, You're considered highly efficient.",
                           { WorkingHours: > 2 and <= 3 } => $"{person.Name}, You're instructed to increase their speed.",
                           { WorkingHours: > 3 and <= 4 } => $"{person.Name}, You need more training.",
                           { WorkingHours: > 5 } => $"{person.Name}, leave the company",
                           _ => $"{person.Name}, Invalid working hours"
                       };
                    }

            #endregion
