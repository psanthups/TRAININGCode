using System;

namespace TRAINING
{
    class Program
    {
        static void PrintingEx()
        {
            Console.WriteLine("Hello World!");
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


            static void Main(string[] args)
        {
            PrintingEx();
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
        }
    }
}
