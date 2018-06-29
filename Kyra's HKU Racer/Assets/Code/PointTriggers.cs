using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTriggers : MonoBehaviour {

    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    void OnTriggerEnter()
    {
        LapCompleteTrigger.SetActive(true);
        HalfLapTrigger.SetActive(false);
    }
}
