using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningZ : MonoBehaviour {

    public GameObject[] obstacle;
    public float distanceZ;
    public float endPoint;
    private float spread = 60.0f;
    // PlayerMovement PlayerMovement= new PlayerMovement();

    // Update is called once per frame
    private void Update()
    {
        int random = Random.Range(0, obstacle.Length);
        distanceZ += spread;
        //transform.position.z += Random.Range(minSpread, maxSpread);
        if (distanceZ < endPoint - spread)
        {
            Instantiate(obstacle[random], new Vector3(transform.position.x, transform.position.y, distanceZ), Quaternion.identity);
        }
        else
        {
        }


    }
}
