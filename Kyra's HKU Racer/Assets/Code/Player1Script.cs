﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour {

    public float speed = 20.0f;

    // Use this for initialization
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {

        float translation = Input.GetAxis("Vertical1") * speed;
        float strafe = Input.GetAxis("Horizontal1") * speed;
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, strafe, 0);





	}
    
}
