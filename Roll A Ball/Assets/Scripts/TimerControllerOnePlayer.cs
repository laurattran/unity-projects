using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerControllerOnePlayer : MonoBehaviour {

    public Text timerLabel;
    public Text timeUP;
    private float timeRemaining = 120;
    int minutes;
    float seconds;


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
        }

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
