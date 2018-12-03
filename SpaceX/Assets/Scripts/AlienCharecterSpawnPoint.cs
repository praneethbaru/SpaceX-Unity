using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCharecterSpawnPoint : MonoBehaviour {

    public GameObject obstacle;
    private float minSpread = -6.0f;
    private float maxSpread = 6.0f;

    // Use this for initialization
    void Start()
    {

        float random = Random.Range(minSpread, maxSpread);
        Instantiate(obstacle, new Vector3(transform.position.x + random, transform.position.y, transform.position.z), Quaternion.identity);
        //Instantiate(obstacle[random], new Vector3(transform.position.x, transform.position.y, distanceZ), Quaternion.identity);

    }
    void Update()
    {

    }
   
}
