using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel02 : MonoBehaviour
{

    public GameObject[] obstacle;
    public float distanceZ;
    //public float endPoint;
    //private float minSpread = 40;
    //private float maxSpread = 80;

    // Update is called once per frame
    private void Update()
    {
        int random = Random.Range(0, obstacle.Length);
        distanceZ += 30.0f;
        //transform.position.z += Random.Range(minSpread, maxSpread);
        if (distanceZ < 700)
        {
            Instantiate(obstacle[random], new Vector3(transform.position.x, transform.position.y,  distanceZ), Quaternion.identity);
        }
        else
        {
            // Debug.Log("CHECKPOINT REACHED");
        }


    }
}
