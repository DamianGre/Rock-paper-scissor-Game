// Rock, paper, scissor game, user vs cpu, earn 3 points to a win game, 1 point for 1 round winned
using System;

try
{
    int playerScore = 0;
    int cpuScore = 0;
    String playAgainCharacter;
    bool playAgain = false;

    String[] cpuAnswers = new String[] { "ROCK", "PAPER", "SCISSORS" };
    String playerAnswer;  

    Random rundomNumber = new Random();
    do {
        playAgain = false;
        playerScore = 0;
        cpuScore = 0;

        do
        {
            do{
                Console.Write("Write - \"Rock\", \"Paper\", \"Scissors\": ");
                playerAnswer = Console.ReadLine();
                playerAnswer = playerAnswer.ToUpper();
            } while (playerAnswer != "ROCK" && playerAnswer != "PAPER" && playerAnswer != "SCISSORS");

            String cpuChoose = cpuAnswers[rundomNumber.Next(0, 3)];
            Console.WriteLine("PLAYER has choose - " + playerAnswer);
            Console.WriteLine("CPU has choose - " + cpuChoose);        

            if (playerAnswer == "ROCK" && cpuChoose == cpuAnswers[0]){
                Console.WriteLine("==== Tie!");
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "ROCK" && cpuChoose == cpuAnswers[1]){
                Console.WriteLine("**** Cpu has WON this round!");
                cpuScore++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "ROCK" && cpuChoose == cpuAnswers[2]){
                Console.WriteLine("^^^^ Player has WON this round!");
                playerScore ++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }

            if (playerAnswer == "PAPER" && cpuChoose == cpuAnswers[0]){
                Console.WriteLine("^^^^ Player has WON this round!");
                playerScore++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "PAPER" && cpuChoose == cpuAnswers[1]){
                Console.WriteLine("==== Tie!");
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "PAPER" && cpuChoose == cpuAnswers[2]){
                Console.WriteLine("**** Cpu has WON this round!");
                cpuScore++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }

            if (playerAnswer == "SCISSORS" && cpuChoose == cpuAnswers[0]){
                Console.WriteLine("**** Cpu has WON this round!");
                cpuScore++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "SCISSORS" && cpuChoose == cpuAnswers[1]){
                Console.WriteLine("^^^^ Player has WON this round!");
                playerScore++;
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }else if (playerAnswer == "SCISSORS" && cpuChoose == cpuAnswers[2]){
                Console.WriteLine("==== Tie!");
                Console.WriteLine("Player score: " + playerScore + "\nCpu score: " + cpuScore);
            }
        } while (playerScore != 3&& cpuScore != 3);

        if (playerScore == 3) {
            Console.WriteLine("\n<<< Player WON! >>>");    
        }
        if (cpuScore == 3)
        {
            Console.WriteLine("\n<<< Cpu WON! >>>");
        }
        do
        {
            Console.Write("Do You wanna play again? Enter `Y` for yes or `N` for no: ");
            playAgainCharacter = Console.ReadLine();
            playAgainCharacter = playAgainCharacter.ToUpper();            
            if (playAgainCharacter == "Y")
            {
                playAgain = true;
            }
            else if (playAgainCharacter == ("N"))
            {
                playAgain = false;
            }
        } while (playAgainCharacter != "Y" && playAgainCharacter != "N");

    }while (playAgain == true) ;
}
catch (Exception ex) {
    Console.WriteLine(ex);
}
