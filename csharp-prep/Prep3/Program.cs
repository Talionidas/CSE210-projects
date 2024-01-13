using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 
        int guess = 0;  //setting guess to 0 so it does not coincidentally equal the magic number

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        }    

        //Taken out user input part
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());            
    }
}