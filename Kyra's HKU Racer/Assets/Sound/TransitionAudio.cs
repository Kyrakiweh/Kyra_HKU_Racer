using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TransitionAudio : MonoBehaviour {

    public AudioMixer mixer;

    private AudioMixerSnapshot normalSnapShot;
    private AudioMixerSnapshot lowVolumeSnap;

	// Use this for initialization
	void Start () {
        normalSnapShot = mixer.FindSnapshot("Normal");
        lowVolumeSnap = mixer.FindSnapshot("LowVolume");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mixer.ClearFloat("MasterVolume");
            lowVolumeSnap.TransitionTo(0.5f);
        }

        if(Input.GetMouseButton(0))
        {
            float currentVolume;

            mixer.GetFloat("MasterVolume", out currentVolume);

            mixer.SetFloat("MasterVolume", currentVolume + .1f);

        }
             

	}
}
