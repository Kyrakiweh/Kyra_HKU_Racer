using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningScript : MonoBehaviour {

    public GameObject WinScreen1;
    public GameObject WinScreen2;

    // Update is called once per frame

    public void Win1()
    {
        WinScreen1.SetActive(true);

    }



    public void Win2()
    {
        WinScreen2.SetActive(true);
    }
    void Update () {

       
	}
}
