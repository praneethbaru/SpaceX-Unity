using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRevolver : MonoBehaviour {

    public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-1*speed, -1*speed, 0*speed);
	}
}
