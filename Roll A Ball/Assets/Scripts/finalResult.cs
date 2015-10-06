using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class finalResult : MonoBehaviour {

    public Text result;
    public Text p1score;
    public Text p2score;
    public Text time;

    private int p1;
    private int p2;
	// Update is called once per frame
	void Update () {
        result.text = time.text;
        if(time.text.Equals("00 : 00"))
        {
            p1 = int.Parse(p1score.text);
            p2 = int.Parse(p2score.text);
            if (p1 > p2)
            {
                result.text = "Player 1 wins!";

            }
            else if (p2 > p1)
            {
                result.text = "Player 2 wins!";
            }
            else
            {
                result.text = "It's a draw!";
            }

        }

    }
}
