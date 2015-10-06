using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menu : MonoBehaviour {
    private int level = 0; //defaults to one player mode
    public Text start;
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            Application.LoadLevel(0);
            level = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Application.LoadLevel(1);
            level = 1;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(level);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
