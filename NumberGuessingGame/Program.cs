// See https://aka.ms/new-console-template for more information

Random random  = new Random();

int winNum = random.Next(0, 100);

bool win = false;

do
{
    Console.Write("Guess a number between 0 and 100:");
    string s = Console.ReadLine();

    int i = int.Parse(s);

    if (i > winNum)
    {
        Console.WriteLine("Too high! Guess lower...");
    }
    else if (i < winNum)
    {
        Console.WriteLine("Too low! Guess higher");
    }
    else if (i == winNum)
    {
        Console.WriteLine("YOU WIN!");
        win = true;
    }

    Console.WriteLine();

} while (win == false);

Console.WriteLine("Thank you for playing the game!");
Console.Write("Press any key to finish.");
Console.ReadKey(true);
