using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject TheJet;
    public float CarX;
    public float CarY;
    public float CarZ;

	void Update () {
        CarX = TheJet.transform.eulerAngles.x;
        CarY = TheJet.transform.eulerAngles.y;
        CarZ = TheJet.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
	}
}
