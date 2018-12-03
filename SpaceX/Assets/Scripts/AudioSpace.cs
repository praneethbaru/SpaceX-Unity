using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpace : MonoBehaviour {

    public AudioSource source;
    public AudioClip clip;
	// Use this for initialization
	void Start () {
        source.clip = clip;
        source.Play();

    }
	
	// Update is called once per frame
	void Update () {

       
       
	}
}
