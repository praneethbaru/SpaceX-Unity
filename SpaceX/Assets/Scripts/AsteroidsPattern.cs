using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsPattern : MonoBehaviour {

    public GameObject[] asteroids;
    public float distanceZ;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int random = Random.Range(0, asteroids.Length);
        distanceZ +=400.0f;
        if (distanceZ <= 700)
        {
            Instantiate(asteroids[random], new Vector3(transform.position.x, transform.position.y, distanceZ), Quaternion.identity);
        }
        else
        {
            // Debug.Log("CHECKPOINT REACHED");
        }
    }
}
