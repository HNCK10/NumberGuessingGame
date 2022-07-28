// See https://aka.ms/new-console-template for more information
Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String response;
//---------------------------
//in this while loop you do not need to say "=true;"
//because it is a boolean that is already checked
//Also note in this while loop we are using the instantiated
//object "random" and getting random numbers from what we initialized earlier
//-----------------------------
while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min,max);
    //We need to keep asking the user if they want to play again
    //for this we can use a nested while loop
    while(guess != number)
    {
        Console.WriteLine("Guess a number between "+ min+" "+max+" :");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: "+guess);
        if(guess > number)
        {
            Console.WriteLine("Your guess is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Your guess is too low!");
        }
        //This is to increment the guesses counter
        guesses++;
    }
    //Need to display the right number
    Console.WriteLine("Number: "+ number);
    Console.WriteLine("You win!");
    //Display how many guesses it took
    Console.WriteLine("It took you: " +guesses);
    Console.WriteLine("Would you like to play again? (Y/N)");
    response = Console.ReadLine();
    response = response.ToUpper();
    if(response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain= false;
    }
}
Console.WriteLine("Thanks for playing!");
Console.ReadKey();