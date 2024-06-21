using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int die1 = random.Next(1, 7); 
        int die2 = random.Next(1, 7);
        int die3 = random.Next(1, 7);

        int bonusPoints = 0;
        if (die1 == die2 || die1 == die3 || die2 == die3)
        {
            bonusPoints += 2;
        }
        if (die1 == die2 && die1 == die3)
        {
            bonusPoints += 6;
        }

        int totalScore = die1 + die2 + die3 + bonusPoints;

        int cutoff = 15;

        if (totalScore >= cutoff)
        {
            Console.WriteLine($"You rolled: {die1}, {die2}, {die3}");
            Console.WriteLine($"Total score: {totalScore}");
            Console.WriteLine("Congratulations! You win!");
        }
        else
        {
            Console.WriteLine($"You rolled: {die1}, {die2}, {die3}");
            Console.WriteLine($"Total score: {totalScore}");
            Console.WriteLine("Sorry, you lose.");
        }
    }
}
