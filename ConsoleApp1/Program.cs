//Imports
using ConsoleApp1;

//Initializing :
// - Players
// - endCondition for our while loop
Player P1 = new Player("Player1");
Player P2 = new Player("Player2");
Dice dice = new Dice();
Boolean endCondition = false;


// While P1 score or P2 score isn't exactly 50 we keep rolling dices and adding the result to the current score
// if either player score ends up above 50 it is set back to 25
while (!endCondition)
{
    P1.Score += dice.RollDice();
    Console.WriteLine("Rolling P1 Dice : " + dice.LastRoll);
    Console.WriteLine("P1 Score : " + P1.Score);
    if (P1.Score == 50) endCondition = true;

    P2.Score += dice.RollDice();
    Console.WriteLine("Rolling P2 Dice : " + dice.LastRoll);
    Console.WriteLine("P2 Score : " + P2.Score);
    if (P2.Score == 50) endCondition = true;

    if (P1.Score > 50) P1.Score = 25;
    if (P2.Score > 50) P2.Score = 25;
}

Console.WriteLine("===========================================");

//Results case
// - If both player got 50, it's a tie
// - If only P1 got 50, it's P1's win
// - If only P2 got 50, it's P2's win
// - If the results doesn't match the previous cases, there was an error in the program

if (P1.Score == 50) Console.WriteLine("Congratulation Player 1");
else if (P2.Score == 50) Console.WriteLine("Congratulation Player 2");
else if (P1.Score == P2.Score) Console.WriteLine("It's a tie !");
else Console.WriteLine("Error while processing scores");

