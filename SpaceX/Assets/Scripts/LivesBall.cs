using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesBall : MonoBehaviour {
    public GameObject life;
    // Use this for initialization
    void Start () {
        Instantiate(life, transform.position, Quaternion.identity);
    }
	
}
