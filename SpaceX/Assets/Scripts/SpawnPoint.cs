using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject obstacle;
	// Use this for initialization
	void Start () {

         Instantiate(obstacle, transform.position, Quaternion.identity);
        //Instantiate(obstacle[random], new Vector3(transform.position.x, transform.position.y, distanceZ), Quaternion.identity);

    }
	

}
