using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteLapTrigScript : MonoBehaviour {

    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public static int lapNr;
    public GameObject LapNumberDisplay;

    public static int lapNr2;
    public GameObject LapNumberDisplay2;



    public GameObject WinScreen1;
    public GameObject WinScreen2;
    public float RestartDelay = 1f;

    public GameObject WinText1;
    public GameObject WinText2;


    private void Start()
    {
        lapNr = 1;
        lapNr2 = 1; 
        LapNumberDisplay.GetComponent<Text>().text = "1";
        LapNumberDisplay2.GetComponent<Text>().text = "1";

    }

    void OnTriggerEnter(Collider  collider) // ff kijken
    {
        if (collider.gameObject.name == "Player1") 
        {
            lapNr += 1;
            LapNumberDisplay.GetComponent<Text>().text = "" + lapNr;

            if (lapNr >= 3)
            {
                win1();
                Invoke("restart", RestartDelay);
                
            }
            
         }
        

        if (collider.gameObject.name == "Player2")
        {
            lapNr2 += 1;
            Debug.Log("speler2 lap");
            LapNumberDisplay2.GetComponent<Text>().text = "" + lapNr2;

            if (lapNr2 >= 3)
            {
               win2();
                Invoke("restart", RestartDelay);
            }
         }


    }

    void win1()
    {
        WinScreen1.SetActive(true);
        WinText1.SetActive(true);
    }

    void win2()
    {
        WinScreen2.SetActive(true);
        WinText2.SetActive(true);
    }
    void restart()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
