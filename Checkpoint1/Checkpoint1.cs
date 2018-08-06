using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            program1();
            program2();
            program3();
            program4();
            program5();
        }
        /*Program 1: Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
         Display the count on the console. */
        public static void program1(){
            // Create the limit for the for loop set to int max so that it can be converted to a user input easily
            int max = 100;
        Console.WriteLine("The Numbers between 1-100 that are divisible by 3 with no remainder are: ");
            // For loop that starts a 1 and checks for any number when divided by 3 = 0 then returns numbers that pass
            for(int i = 1; i <= max; i++){
                if (i % 3 == 0){
                    Console.WriteLine(i);
                }
            }
          Console.ReadLine();
        }
        /* Program 2: Write a program and continuously ask the user to enter a number or "ok" to exit. 
        Calculate the sum of all the previously entered numbers and display it on the console. */
        public static void program2(){
            var sum = 0;
            Console.WriteLine("I Will Calculate the sum of all numbers entered.");
            Console.WriteLine("Please Enter a number or type ok to exit and recieve your sum:");
            // While Statement that takes the user statement as a string then checks for the string ok 
            // If statement equals ok break the loop if not keep adding up the sum of numbers
            while (true)
            {
                    String answer = Console.ReadLine();
                    if (answer == "ok" || answer.ToLower() == "ok") break;
                    // convert user inputs from string to int to calcualte sum
                    sum += Convert.ToInt32(answer);
            }
        Console.WriteLine("Your sum of numbers entered is: "+sum);
        Console.ReadLine();
        }
        /* Program 3: Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
        For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. */
        public static void program3(){
            int i, number, fact;
            Console.WriteLine("Please Enter a Number and I will compute the factoral of the number for you.");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\n"+number+"! = "+fact);
            Console.ReadLine();
            
        }
        /* Program 4: Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        If the user guesses the number, display “You won"; otherwise, display “You lost". 
        (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
        public static void program4(){
            int tries = 4;
            int trynum = 1;
            int guess;
            // Create a random number between 1-10
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            // Console.WriteLine(num);
            Console.WriteLine("Let's play a game. Ill pick a number between 1 and 10 and you have 4 tries to guess the number.");
            String input = Console.ReadLine();
            guess = Convert.ToInt32(input);
            while (guess != num && trynum < tries){
                Console.WriteLine("Incorrect Number Please Try Again.");
                input = Console.ReadLine();
                guess = Convert.ToInt32(input);
                trynum++;
            }
            if(guess == num){
                Console.WriteLine("You win!");
            }
            if(trynum == tries){
                Console.WriteLine("You Lose! Try again.");
                }
             Console.ReadLine();

        }
        /* Program 5: Write a program and ask the user to enter a series of numbers separated by comma. 
        Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8. */
        public static void program5(){
            var max = 0;
            Console.WriteLine("Please enter a series of numbers sperated by a comma.");
            string input = Console.ReadLine();
            // Make an array of numbers using a , as a spliting point
            string[] numbers = input.Split(",");
                for (var i = 0; i < numbers.GetLength(0); i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                }
            }
            Console.WriteLine("The Largest number you entered was "+max);
            Console.ReadLine();

        }
    }
}
