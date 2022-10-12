//Declaring :
// - player's score
// - Random number seed
// - endCondition for our while loop
int P1 = 0, P2 = 0;
Random rnd = new Random();
Boolean endCondition = false;


// While P1 score or P2 score isn't exactly 50 we keep rolling dices and adding the result to the current score
// if either player score ends up above 50 it is set back to 25
while (!endCondition)
{
    int P1Roll = rnd.Next(6);
    P1 += P1Roll;
    Console.WriteLine("Rolling P1 Dice : " + P1Roll);
    Console.WriteLine("P1 Score : " + P1);
    if (P1 == 50) endCondition = true;

    int P2Roll = rnd.Next(6);
    P2 += P2Roll;
    Console.WriteLine("Rolling P1 Dice : " + P2Roll);
    Console.WriteLine("P2 Score : " + P2);
    if (P2 == 50) endCondition = true;

    if (P1 > 50) P1 = 25;
    if (P2 > 50) P2 = 25;
}

Console.WriteLine("===========================================");

//Results case
// - If both player got 50, it's a tie
// - If only P1 got 50, it's P1's win
// - If only P2 got 50, it's P2's win
// - If the results doesn't match the previous cases, there was an error in the program

if (P1 == 50) Console.WriteLine("Congratulation Player 1");
else if (P2 == 50) Console.WriteLine("Congratulation Player 2");
else if (P1 == P2) Console.WriteLine("It's a tie !");
else Console.WriteLine("Error while processing scores");

