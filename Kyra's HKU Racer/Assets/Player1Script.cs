using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour {
    public float inputDelay = 0.1f;
    public float Speed = 12;
    public float rotationVel = 90;
    

    private Quaternion targetRotation;
    private Rigidbody rBody;
    float forwardInput, turnInput;

    
    public Quaternion TargetRotation
    {
        get { return.targetRotation; }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;


	}
}
