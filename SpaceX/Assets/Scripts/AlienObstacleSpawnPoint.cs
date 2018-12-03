using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienObstacleSpawnPoint : MonoBehaviour {

    public GameObject obstacle;
    public float spawnTime = 2f;
    private float minSpread=-6.0f;
    private float maxSpread=6.0f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("ObstacleInstantiation", 1f , 2f);
	}
    void Update()
    {

    }
    // Update is called once per frame
    void ObstacleInstantiation () {
        float random = Random.Range(minSpread, maxSpread);
        Instantiate(obstacle , new Vector3(transform.position.x+random,transform.position.y,transform.position.z), Quaternion.identity);
      
    }
}
