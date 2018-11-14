using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstacle;
    public float startTimeBtwSpawn;
    private float timeBtwSpawn;
    public float distanceZ;
    public float minSpread = 40;
    public float maxSpread = 80;

    // Update is called once per frame
    private void Update ()
    {
        int random = Random.Range(0, obstacle.Length);
        distanceZ += 30.0f;
        //transform.position.z += Random.Range(minSpread, maxSpread);
        if (distanceZ <= 400)
        {
            Instantiate(obstacle[random], new Vector3(transform.position.x, transform.position.y, distanceZ), Quaternion.identity);     
        }
        else
        {
            Debug.Log("CHECKPOINT REACHED");
        }
        
       
	}
}
