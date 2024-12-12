﻿namespace Assignment_2___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Value Type Casting
            #region Implicit Casting - Save Casting
            //int x = 4;
            //long y =/*(long)*/ x;// we can save int in long becouse it save in 4 byte
            //                     // and long in 8 byte so we dont need to make cast
            #endregion

            #region Explicit Casting - UnSave Casting
            //long x = 101010101000000000; //8byte
            ////int y = x  , it is error becouse we cannot add long(8 byte) to int(4 byte) without convert it (Explicit Casting) 
            //int y = (int)x; // 4byte , we must use (Explicit Casting)the x into (int) to cenvert it from long to int 
            //Console.WriteLine(y); // output will be overflow number becouse the int save 4 byte only

            //double X = 88.88;
            //int Y = (int) X;// output will be 88 so the Explicit Casting - UnSave Casting becouse it 
            //                   // change the value
            //Console.WriteLine(Y);   
            #endregion

            #region parse
            //int x = int.Parse(Console.ReadLine());
            // parse it is method inside the struct , it is using to convert from string to any datatype

            //Console.WriteLine("Enter Data User");

            //Console.Write("Enter Name = ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Age = ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.Write("Enter Salary = ");
            //int Salary = int.Parse(Console.ReadLine());

            //Console.Clear(); // clear console and save data 

            //Console.WriteLine("Name: " + name + " Age : " + Age + "Salary : " + Salary);

            #endregion

            #region Convert 
            // it convert from any data type to any data type and it is class

            //Console.WriteLine("Enter Data User");

            //Console.Write("Enter Name = ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Age = ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Salary = ");
            //double Salary = Convert.ToDouble(Console.ReadLine()) ;

            //Console.Clear(); // clear console and save data 

            //Console.WriteLine("Name: " + name + " Age : " + Age + "Salary : " + Salary);
            #endregion
            #endregion

            #region Operation
            #region Unary Operation [++,--]
            //int x = 4;
            //x++;//postfix print then increament o/p 5
            //++x;//prefix increament then pront o/p 5
            //x--;//postfix
            //--x;//prefix

            #endregion

            #region Binary
            // +,-,/,*,%
            #endregion

            #region Assigment Operator
            //int x = 5;
            //x += 10;//20
            //x -= 10;
            //x *= 10;
            //x /= 10;
            //x %= 10;

            #endregion

            #region Relational
            // ==,<= ,>=,!=,>,<
            #endregion

            #region logical [short circut]
            //Console.WriteLine(!true);// !(not)
            // True && True ----> True
            // True && False ----> False
            // False && True ----> False
            // False && False ----> False

            // True || True ----> True
            // True || False ----> True
            // False || True ----> True
            // False || False ----> False
            #endregion

            #region BitWise [long circut]
            // True & True ----> True
            // True & False ----> False
            // False & True ----> False
            // False & False ----> False

            // True | True ----> True
            // True | False ----> True
            // False | True ----> True
            // False | False ----> False
            #endregion

            #region ternary 
            //int x = 4;
            //string msg = x > 4 ? "X > 4" : "x<=4";
            //Console.WriteLine(msg);
            #endregion

            #endregion

            #region Operator periorety
            /*
             1. unary operator [prefix >> ++x]
             2. ()
             3. * / %
             4. + , -
            */
            //int x = 10;
            //int y = 10;
            //int res = ++x * y;
            //Console.WriteLine(res);
            #endregion

            #region String formate
            #region string concatunation [+]
            //int x = 5;
            //int y = 10;
            //int z = 15;
            //Console.WriteLine("Equation = " + x + " + " + y + " = " + z);// worset formate 
            //string concatunation is worest formate becouse string is immutable object
            #endregion

            #region composite formate [string.formate()] 
            // بحجز مكان لل varables , using method in string object name formate()
            //string msg = string.Format("Equation = {0} + {1} = {2}", x, y, z);
            //Console.WriteLine(msg);
            //or
            //Console.WriteLine("Equation = {0} + {1} = {2}", x, y, z);
            #endregion

            #region string manuplation [$]
            //Console.WriteLine($"Equation = {x} + {y} = {z}");// the recommended
            #endregion
            #endregion

            #region IF - Else , Switch case
            //Console.Write("Enter month : ");
            //int month = int.Parse(Console.ReadLine());

            //if (month == 1)
            //{
            //    Console.WriteLine("month is jan");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("month is feb");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("month is feb");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            // switch
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("month is jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("month is feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("month is mar");
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;

            //}

            // switch not numeric
            //string name = Console.ReadLine();
            //switch(name)
            //{
            //    case "Ahmed":
            //   case "ahmes":
            //        Console.WriteLine("month is jan");
            //        break;

            //}
            /*
             * in numeric:
                note that switch case is best than if becouce if user enter numeric number
                the switch case make Jumping Table that have flag if user enter value match 
                with cases does not go step by step in all step it is go to the cases which matvh
                , but if go stop by step in all cases if numeric or not
             * in not numeric
                the switch case make Jumping table if count of cases < 5 , and will
                go step by step if ciunt of cases > 5
            */
            #endregion

            #region Goto with switch
            //int option = int.Parse(Console.ReadLine());
            //switch (option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 3");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 2");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 1");
            //        break;
            //}
            #endregion

            #region Evaualtion of switch case
            #region C#6
            //Console.WriteLine("enter the age");
            //int age = int.Parse(Console.ReadLine());

            //switch(age)
            //{
            //    case  > 20 :
            //        Console.WriteLine(" age > 20");
            //        break;
            //    case  < 20:
            //        Console.WriteLine(" age < 20");
            //        break;
            //}
            #endregion

            #region C#7
            //// can we check on multiple data type and add condation in case too using when 
            //object obj = new object();
            //obj = "ALi";
            //obj = 15;
            //obj = true;
            //switch(obj)
            //{
            //    case int number when number >10 && number < 30:
            //        Console.WriteLine($"{number} is int");
            //        break;
            //    case bool flag:
            //        Console.WriteLine($"{flag} is bool");
            //        break;
            //}
            #endregion

            #region C#8
            // in c38 add [ 1.constant option , 2.discard option , 3.property option]
            //int option = int.Parse(Console.ReadLine());
            //string msg = option switch
            //{
            //    1 => "option 1",  // 1 it is constant option
            //    2 => "option 2",
            //    _ => "invalid"     //_ it is discard option
            //};
            //Console.WriteLine(msg);

            //ex-2
            //3.property option
            //Employee emp = new Employee();
            //emp.Name = "Ali";
            //emp.Id = 1;
            //emp.Age = 30;

            //string msg = emp switch
            //{
            //    { Name: "mo", Age: 20, Id: 2 } => $"{emp.Name} : {emp.Age} : {emp.Id} " ,
            //    { Name: "Ali", Age: 30, Id: 1 } => $"{emp.Name} : {emp.Age} : {emp.Id} " ,
            //    { Name: "nor", Age: 50, Id: 7 } => $"{emp.Name} : {emp.Age} : {emp.Id} " ,
            //};
            //Console.WriteLine(msg);
            #endregion

            #region C#9
            // add relational pattern[>,<,.....] and logical[and , or , not]
            //Employee emp = new Employee();
            //emp.Name = "mo";
            //emp.Id = 2;
            //emp.Age = 19;

            //string msg = emp switch
            //{
            //    { Name: "mo", Age: >18 and < 21 , Id: 2 } => $"{emp.Name} : {emp.Age} : {emp.Id} ",
            //    { Name: "Ali", Age: 30, Id: 1 } => $"{emp.Name} : {emp.Age} : {emp.Id} ",
            //    { Name: "nor", Age: 50, Id: 7 } => $"{emp.Name} : {emp.Age} : {emp.Id} ",
            //};
            //Console.WriteLine(msg);
            #endregion

            #endregion
            #endregion

            #region Assignment

            #region Q1
            //Console.Write("Input: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("output: Yes");
            //}
            //else
            //{
            //    Console.WriteLine("output: No");
            //}
            #endregion

            #region Q2
            //Console.Write("Input: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0) 
            //{
            //    Console.WriteLine("Output: negative");
            //}
            //else
            //{
            //    Console.WriteLine("Output: positive");
            //}
            #endregion

            #region Q3
            //Console.WriteLine("input"); 
            //Console.Write("num01: ");
            //int num01 = int.Parse(Console.ReadLine());
            //Console.Write("num02: ");
            //int num02 = int.Parse(Console.ReadLine());
            //Console.Write("num03: ");
            //int num03 = int.Parse(Console.ReadLine());

            //int maximum = num01;
            //int minmun = num01;
            //if (num02 > maximum)
            //    maximum = num02;
            //if (num03 > maximum)
            //    maximum = num03;
            //if (num02 < minmun)
            //    minmun = num02;
            //if (num03< minmun)
            //    minmun = num03;
            //Console.WriteLine("output : "  );
            //Console.WriteLine($"max element = {maximum}");
            //Console.WriteLine($"min element = {minmun}");
            #endregion

            #region Q4
            //Console.Write("Input: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("output: Even");
            //}
            //else
            //{
            //    Console.WriteLine("output: Odd");
            //}
            #endregion
            #endregion
        }
    }
}