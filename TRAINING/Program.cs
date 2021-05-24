using System;

namespace TRAINING
{
    class Program
    {
        static void PrintingEx()
        {
            Console.WriteLine("Hello World! ");
        }

        static void DeclareVar()
        {
            int varable1 = 12;
            string varable2 = "it's a string";
            Console.WriteLine("varable1 is : " + varable1 + "and vsrable2 is : " + varable2);

        }

        static void GreatOfThree()
        {
            int a = 12, b = 15, c = 11;
            if (a >= b && a >= c)
            
                Console.WriteLine(a + " is the greatest number");
            
            else if (b >= a && b >= c)
            
                Console.WriteLine(b + " is the greatest number");
            
            else
                Console.WriteLine(b + " is the greatest number");
        }

        static void RevOfNum()
        {
            int number = 258;
            int Reverse = 0;
            Console.WriteLine(number);

            while (number>0)
            {
                int temp;
                temp = number % 10;
                Reverse = Reverse * 10 + temp;
                number = number / 10;
            }
           
            Console.WriteLine("reverse of given number is " + Reverse);
        }

        static void SumOfTwo()
        {
            int num1 = 12, num2 = 23;
            int sum = num2 + num1;
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            Console.WriteLine("sum of num1 and num2 is = " + sum);


        }

        static void FactEx()
        {
            int n1 = 5;
            int i = 1;
            int fact = 1;
           

            while (i<=n1)
            {
                fact = fact * i;
                i++;
                
            }
            Console.WriteLine(" n1 = " + n1);
            Console.WriteLine("factorial of n1 = " + fact); 
        }

        static void PalendromeEx()
        {
            int givenNum= 4554;
            int ReverseNum = 0;
            Console.WriteLine("given number = " + givenNum);
            int hold = givenNum;
            while (givenNum > 0)
            {
                int temp1;
                temp1 = givenNum % 10;
                ReverseNum = ReverseNum * 10 + temp1;
                givenNum = givenNum / 10;
            }

            Console.WriteLine("reverse of given number is " + ReverseNum);
            if (hold == ReverseNum)
            
                Console.WriteLine(" hence number is a palendrome");
            
            else
                Console.WriteLine("hence number is not a palendrome");
        }

        static void SwapTwo()
        {
            int integer1 = 10, integer2 = 5;
            int temp = 0;
           Console.WriteLine("before swaping integer1 =  " + integer1+ " and integer2 = " + integer2);
            temp = integer1;
            integer1 = integer2;
            integer2 = temp;
            Console.WriteLine("after swaping integer1 =  " + integer1 + " and integer2 = " + integer2);

        }

        static void PrimeEx()
        {
            int numberIs = 9;
            int j = 2;
            int term = 0;
            while(j<numberIs)
            {
                if (numberIs % j == 0)
                {
                    Console.WriteLine("given number is not a prime");
                    term = 1;
                    break;
                }
               
                j++;
                
            }
            if (term == 0)
                Console.WriteLine("given number is a prime");
           
        }

        static void NaturalEx()
        {
            int k = 1;
            Console.WriteLine("first 10 natural numbers are : ");

            while (k <= 10)
            {

                Console.WriteLine(k);
                k++;
            }
        }

        static void InputCalculationsEx()
        {
            Console.WriteLine("Enter any two values ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            Console.WriteLine(" sum of given numbers = " + sum);
            Console.WriteLine("substraction of given numbers = " + substraction);
            Console.WriteLine("multiplication of given numbers = " + multiplication);
            Console.WriteLine("division of given numbers = " + division);


        }

        static void OneInputCalculationsEx()
        {

            int a = 6;
            Console.WriteLine("a = " + a);
            Console.WriteLine("Enter any value ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            Console.WriteLine(" sum of given numbers = " + sum);
            Console.WriteLine("substraction of given numbers = " + substraction);
            Console.WriteLine("multiplication of given numbers = " + multiplication);
            Console.WriteLine("division of given numbers = " + division);


        }

        static void MaxOfTwo()
        {
            int number1 = 46, number2 = 18;
            Console.WriteLine("number1 = " + number1);
            Console.WriteLine("number2 = " + number2);
            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is maximum from above");
            }
            else
                Console.WriteLine(number2 + " is maximum from above");

        }

        static void MaxOfThree()
        {
            int n1 = 46, n2 = 85, n3 = 18;
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);
            Console.WriteLine("n3 = " + n3);
            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1 + " is maximum from above");
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2 + " is maximum from above");
            }
            else
                Console.WriteLine(n3 + " is maximum from above");
        }

        static void NaturalNnumEx()
        {
            int one = 1;
            Console.WriteLine("print natural numbers upto.. ?   enter number");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("natural numbers are : ");
           
            while (one <= limit)
            {

                Console.WriteLine(one);
                one++;
            }
        }


        class day3
        {
            public static void EvenOddEx()
            {
                int number = 46;
                int check = number % 2;
                if (check == 0)
                {
                    Console.WriteLine("given number is even");
                }
                else
                    Console.WriteLine("given number is odd");
            }

            public static void WovelEx()
            {
                Console.WriteLine("Enter any character only");
                char alphabet = Convert.ToChar(Console.ReadLine());
                if (alphabet >= 0 || alphabet < 0)
                {
                    Console.WriteLine("you entered wrong value");
                }
                else if (alphabet == 'a' || alphabet == 'A' || alphabet == 'e' || alphabet == 'E' || alphabet == 'i' || alphabet == 'I' || alphabet == 'o' || alphabet == 'O' || alphabet == 'u' || alphabet == 'U')
                {
                    Console.WriteLine("given aplhabet is wovel");
                }
                else
                    Console.WriteLine("given alphbet is not wovel ");
            }


            public static void PosiveOrNegativeEx()
            {
                Console.WriteLine("Enter any number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("given number is zero");
                }
                else if (number > 0)
                {
                    Console.WriteLine(number + "  is positive");
                }
                else
                    Console.WriteLine(number + "  is negative");
            }

            public static void AlphabetOrNotEx()
            {
                Console.WriteLine("Enter any character");
                char value = Convert.ToChar(Console.ReadLine());
                if (value >= 'a' && value <= 'z' || value <= 'A' && value >= 'Z')
                {
                    Console.WriteLine(value + " is alphabet");
                }
                else
                    Console.WriteLine(value + " is not alphabet  ");
            }

            public static void MultiplicatioNnumEx()
            {
                int i = 1;
                Console.WriteLine("enter any number to get its table");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("multiplication of " + num);
                int a = 10;
                while (i <= a)
                {

                    Console.WriteLine(num + "*" + i + "=" + num * i);
                    i++;
                }
            }

            public static void EvenNoEx()
            {
                Console.WriteLine("print even numbers upto... enter number");
                int upto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Even numbers upto: " + upto + " are");
                int i;
                int check;
                for (i = 0; i <= upto; i++)
                {
                    check = i % 2;
                    if (check == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            public static void OddNoEx()
            {
                Console.WriteLine("print Odd numbers upto... enter number");
                int upto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Odd numbers upto: " + upto + " are");
                int i;
                int check;
                for (i = 0; i <= upto; i++)
                {
                    check = i % 2;
                    if (check != 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            public static void MultiOf2Ex()
            {
                int table = 2;
                int i = 1;
                Console.WriteLine("multiplication table of " + table);
                int a = 10;
                while (i <= a)
                {

                    Console.WriteLine(table + "*" + i + "=" + table * i);
                    i++;
                }
            }


            public static void LeapYearEx()
            {

                Console.WriteLine("Enter Year : ");
                int Year = Convert.ToInt32(Console.ReadLine());
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine(" is a Leap Year.", Year);
                }
                else
                    Console.WriteLine(" is not a Leap year");
            }
        }

        class day4
        {
            public static void SumOfNatEx()
            {
                int a = 1;
                Console.WriteLine("enter number to get sum upto that number");
                int limit = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("natural numbers are : ");
                int sum = 0;
                while (a <= limit)
                {

                    Console.Write(a+ "+");
                    sum = sum + a;

                   a++;
                }
                Console.WriteLine("");

                Console.WriteLine("sum of natural numbers are : ");
                Console.WriteLine(sum);
            }

             public static void FactorsEx()
            {
                Console.WriteLine("enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the factors of " + num + " are : ");
                int i;
                for(i=1;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }


            public static void GcdEx()
            {
                int i;
                int gcd=0;

                Console.WriteLine("Enter two integers: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= n1 && i <= n2; i++)
                {
                 
                    if (n1 % i == 0 && n2 % i == 0)
                        gcd = i;
                }

                Console.WriteLine("the gcd of "+n1+" and "+n2+ " is "+ gcd);
            }


            public static void LcdEx()
            {
                int i;
                int gcd = 0;
                int lcd;

                Console.WriteLine("Enter two integers: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= n1 && i <= n2; i++)
                {
               
                    if (n1 % i == 0 && n2 % i == 0)
                        gcd = i;
                }
                lcd = (n1 * n2) / gcd;

                Console.WriteLine("the lcd of " + n1 + " and " + n2 + " is " + lcd);
            }


            public static void AreaOfCircle()
            {
                Console.WriteLine("enter radius of the circle");
                int a = Convert.ToInt32(Console.ReadLine());
                int area = (22 / 7) * a * a;
                Console.WriteLine("area of the circle is : "+ area);
            }


            public static void AreaOfRectangle()
            {
                Console.WriteLine("enter length of rectangle");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter width of rectangle");
                int width = Convert.ToInt32(Console.ReadLine());
                int area =  length * width;
                Console.WriteLine("area of the rectangle is : " + area);
            }

            public static void StringConcat()
            {
                string a = "Hi";
                string b = "Iam santhosh";
                string c = "from warangal";
               
                string d = string.Concat( a,", ",b," ",c);
                string e = a + ", " + b +" "+ c;
                Console.WriteLine(d);
                Console.WriteLine(e);


            }


            public static void NumOfDigits()
            {
                
                int i = 0;
                Console.WriteLine("enter any number");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num != 0)
                {
                    num = num / 10;
                    
                    i++;
                }
                Console.WriteLine(i);
            }

            public static void MarksAndAverage()
            {
                Console.WriteLine("enter roll number");
                int rollnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter marks of 1st subject");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter marks of 2nd subject");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter marks of 3rd subject");
                int m3 = Convert.ToInt32(Console.ReadLine());
                int total = m1 + m2 + m3;
                int avg = total / 3;
                Console.WriteLine("total marks for above subjects are : " + total);
                Console.WriteLine("marks average is : " + avg);
            }

            public static void Sort()
            {
             
                Console.WriteLine("enter any three numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                if ((a >= b) && (a >= c))
                {
                    if (b >= c)
                    {
                        Console.WriteLine(" Descending order : "+ a+" "+ b+" "+ c);
                        Console.WriteLine(" Ascending order : "+ c+" " + b+" "+ a);
                    }
                    else
                    {
                        Console.WriteLine("Descending order  : "+ a+" "+ c+" "+ b);
                        Console.WriteLine("Ascending order : "+ b+" "+c+" "+ a);
                    }
                }
                else if ((b >= a) && (b >= c))
                {
                    if (a >= c)
                    {
                        Console.WriteLine("Descending order : "+ b+ " "+ a+" "+ c);
                        Console.WriteLine("Ascending order : "+ c+ " " + a+" "+ b);
                    }
                    else
                    {
                        Console.WriteLine("Descending order : "+ b+" "+ c+" "+ a);
                        Console.WriteLine("Ascending order : "+ a+" "+ c+" "+ b);
                    }
                }
                else if ((c >= a) && (c >= b))
                {
                    if (a >= b)
                    {
                        Console.WriteLine("Descending order : "+ c+" "+ a+" "+ b);
                        Console.WriteLine("Ascending order : "+ b+" "+ a+" "+ c);
                    }
                    else
                    {
                        Console.WriteLine("Descending order : "+ c+" "+ b+" " +a);
                        Console.WriteLine("Ascending order : "+ a+" "+ b+" "+ c);
                    }
                }



            }

            public static void ReverseArr()
            {
                int i = 5;
                int[] arr = new int[i];
                
                
                Console.WriteLine("Enter 5 elements: ");
                for(i = 0; i <arr.Length; i++)
                {
                   arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("elements in reverse order: ");
                for (i = arr.Length - 1; i >= 0; i--)
                { 
                    Console.WriteLine(" " + arr[i]);
                }
            }



        }
         
        class day5
        {
            public static void SumOfDigits()
            {
                Console.WriteLine("enter any number");
                int a = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                int temp = 0;
                while(a>0)
                {
                    temp =temp + (a % 10);
                    a = a / 10;
                    i++;
                   
                }
                Console.WriteLine("Sum of the digits of entered number : "+temp);
            }

            public static void BinaryTriangle()
            {
                int n = 4;
                int row, col;

                for (row = 0; row < 10; row++)
                {
                    for (col = 0; col <= row; col++)
                    {
                        if (((row + col) % 2) == 0)
                            Console.Write("0");
                        else
                            Console.Write("1");

                        Console.Write("");
                    }

                    Console.WriteLine();
                }
            }


            public static void CountOnes()
            {
                Console.WriteLine("enter any number");
                int a = Convert.ToInt32(Console.ReadLine());
                int i =0;
                int c;
                int f = 0;
                while(a>0)
                {
                    c = a % 10;
                    if (c == 1)
                    {
                        f = f + 1;
                    }
                   a= a / 10;
                    i++;
                }
                Console.WriteLine(f+"khkjhkh");
            }

            public static void Arr()
            {
                
                
                int[] array = { 1, 2, 3, 4, 5 };
                foreach (int i in array)
                {
                    Console.Write(" "+i);
                }
            }

            public static void ArrRev()
            {
                int[] array = { 1, 2, 3, 4, 5 };
                foreach (int i in array)
                {
                    Console.Write(" " + i);
                }
                int j;
                Console.WriteLine("");

               Console.WriteLine("elements in reverse order: ");
                for (j = array.Length - 1; j >= 0; j--)
                {
                    Console.WriteLine(" " + array[j]);
                }
            }

            public static void DivideOfTwo()
            {
                int num1 = 12, num2 = 23;
                int divide = num2 / num1;
                Console.WriteLine("num1 = " + num1);
                Console.WriteLine("num2 = " + num2);
                Console.WriteLine("divide of num1 and num2 is = " + divide);


            }
            public static void multi()
            {
                Console.WriteLine("enter 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 2nd number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 3rd number");
                int c = Convert.ToInt32(Console.ReadLine());
                int multip = a * b * c;
                
                Console.WriteLine("multiplication of three num are: " + multip);
            }


            public static void averag()
            {
                Console.WriteLine("enter 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 2nd number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 3rd number");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 4th number");
                int d = Convert.ToInt32(Console.ReadLine());
                int total = a + b + c + d;
                int avg = total / 4;
                Console.WriteLine("average of 4 num are: " +avg);
            }
        }
        





        static void Main(string[] args)
        {
            /*  PrintingEx();
              DeclareVar();
              GreatOfThree();
              RevOfNum();
              SumOfTwo();
              FactEx();
              PalendromeEx();
              SwapTwo();
              PrimeEx();
              NaturalEx();
              InputCalculationsEx();
              OneInputCalculationsEx();
              MaxOfTwo();
              MaxOfThree();
              NaturalNnumEx();

              //day3
              day3 eveodd = new day3();
              day3.EvenOddEx();
              day3.WovelEx();
              day3.PosiveOrNegativeEx();
              day3.AlphabetOrNotEx();
              day3.MultiplicatioNnumEx();
              day3.EvenNoEx();
              day3.OddNoEx();
              day3.MultiOf2Ex();
              day3.LeapYearEx(); 

            //day4
            day4.SumOfNatEx();
            day4.FactorsEx();
            day4.GcdEx();
            day4.LcdEx();
            day4.AreaOfCircle();
            day4.AreaOfRectangle();
            day4.StringConcat();
            day4.NumOfDigits();
            day4.MarksAndAverage();
            day4.Sort();
            day4.ReverseArr();*/
            //day5
            // day5.SumOfDigits();
            // day5.BinaryTriangle();
            // day5.CountOnes();
            //day5.Arr();
            // day5.ArrRev();
            //day5.DivideOfTwo();
            //day5.multi();
            day5.averag();

        }
    }
}
