using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerController : MonoBehaviour {

    public Text timerLabel;
    public Text timeUP;
    private float timeRemaining = 120;
    int minutes;
    float seconds;

    public Text result;
    public Text p1score;
    public Text p2score;

    private int p1;
    private int p2;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
         if(timeRemaining > 0)
        {
            minutes = (int)timeRemaining / 60; 
            seconds = timeRemaining % 60;
        }
        else
        {
            minutes = 0;
            seconds = 0;
            timeUP.text = "Time's Up!";
            p1 = int.Parse(p1score.text);
            p2 = int.Parse(p2score.text);
            if(p1>p2)
            {
                result.text = "Player 1 wins!";
            }
            else if(p2>p1)
            {
                result.text = "Player 2 wins!";
            }
            else
            {
                result.text = "It's a draw!";
            }

        }

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
