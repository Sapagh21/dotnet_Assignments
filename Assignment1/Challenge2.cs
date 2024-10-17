/* 
Problem Statement : 
Create an application with a score, highscore and a
highscorePlayer.
Create a method which has two parameters, one for the score and
one for the playerName.
When ever that method is called, it should be checked if the score
of the player is higher than the highscore, if so, "New highscore
is + " score" and in another line "New highscore holder is " +
playerName - should be written onto the console, if not "The old
highscore of " + highscore + " could not be broken and is still held
by " + highscorePlayer.
Consider which variables are required globally and which ones
locally.
*/
using System; 
namespace Game
{
    class Player
    {  
    public static int highestScore = 0;
    public static string highScoreName = "";

    public static void startGame(){
        Player t = new Player();
        t.checkHighScore(50, "seif");   
        t.checkHighScore(50, "Ahmed"); 
        t.checkHighScore(70, "Ali"); 
    }

    void checkHighScore(int score, string playerName){
        if (score > highestScore){
            highestScore = score;
            highScoreName = playerName;
            Console.WriteLine("New High Score is: {0}\nNew Highscore Holder is: {1}",highestScore,highScoreName);
        }else{
            Console.WriteLine("The old highscore of {0} couldn\'t be broken and is still held by {1}",highestScore,highScoreName);
        }
    }



    }
}
