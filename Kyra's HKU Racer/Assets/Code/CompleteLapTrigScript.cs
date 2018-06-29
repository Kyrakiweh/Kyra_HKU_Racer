using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteLapTrigScript : MonoBehaviour {

    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public static int lapNr;
    public GameObject LapNumberDisplay;

    public static int lapNr2;
    public GameObject LapNumberDisplay2;

   

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

            if (lapNr >= 2)
            {

            }
            
         }
        

        if (collider.gameObject.name == "Player2")
        {
            lapNr2 += 1;
            Debug.Log("speler2 lap");
            LapNumberDisplay2.GetComponent<Text>().text = "" + lapNr2;
         }



        
    }
}
