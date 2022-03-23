Random player = new Random();
int person = player.Next(1, 101);
int guess, guess_loop;
guess_loop = 0;
// Console.WriteLine(person);
guess_loop:
while (guess_loop > -1)
{
    guess_loop += 1;
    Console.WriteLine();
    Console.Write("Please Enter you're Guess    : ");
    Console.WriteLine();
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == person)
    {
        Console.WriteLine("got em");
        Console.WriteLine("You did it in " + guess_loop + " Guesses");
        Thread.Sleep(1000);
        goto getting_correct;
    }
    else if (guess >= person)
    {
        Console.WriteLine("incorrect");
        Console.WriteLine();
        Console.WriteLine("You are to high");
        Thread.Sleep(1000);
        goto guess_loop;
    }
    else if (guess <= person)
    {
        Console.WriteLine("incorrect");
        Console.WriteLine();
        Console.WriteLine("You are to Low");
        Thread.Sleep(1000);
        goto guess_loop;
    }
}
getting_correct:
Console.WriteLine();
Console.WriteLine("Congragulations");

