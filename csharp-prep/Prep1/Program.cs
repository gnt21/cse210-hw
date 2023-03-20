using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");

        /*Exercise2*/
        
        /*
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        string letter;

        if (int.Parse(gradePercentage) < 60) 
        {
            letter = "F";
        }
        else if (int.Parse(gradePercentage) <= 70) 
        {
            letter = "D";
        }  
        else if (int.Parse(gradePercentage) <= 80) 
        {
            letter = "C";
        }  
        else if (int.Parse(gradePercentage) <= 90) 
        {
            letter = "B";
        }  
        else
        {
            letter = "A";
        }  

        Console.WriteLine($"Your grade is {letter}");

        if(int.Parse(gradePercentage) < 70)
        {
            Console.WriteLine("Sorry, I'm sure you will pass in the next time");
        }
        else
        {
            Console.WriteLine("Congratulation, you passed the class");
        }
        */
        /*Exercise3*/

        /*
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 11);
        /*
        Console.WriteLine("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        */
        /*
        int guess = -1;

        while(guess != magic)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if(guess < magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        */

        /*Exercise 4*/
        /*
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        List<int> numeros = new List<int>();
        int numero = -1;
        do
        {
            Console.Write("Enter number: ");
            numero = int.Parse(Console.ReadLine());
            if (numero != 0)
            {
                numeros.Add(numero);
            }
        } while (numero != 0);

        int soma = 0;
        int largest = 0;
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
            soma = soma + item;
            if (item > largest)
            {
                largest = item;
            }
        }

        Console.WriteLine($"The sum is: {soma}");
        Console.WriteLine($"The average is: {((float)soma)/numeros.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        */
        /*Exercise 5*/

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
}