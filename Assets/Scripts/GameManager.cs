using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

     public Text playerScoreText;
    public Text computerScoreText;
    
    private int _playerscore;
    private int _computerscore;
   
    public void PlayerScores(){
        _playerscore++;
        this.playerScoreText.text=_playerscore.ToString();
        ResetRound();
    }
    public void ComputerScores(){
        _computerscore++;
        this.computerScoreText.text=_computerscore.ToString();
        ResetRound();
    }
    private void ResetRound(){
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
       this.ball.AddStartingForce();
    }
}
