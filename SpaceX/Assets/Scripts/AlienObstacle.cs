using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienObstacle : MonoBehaviour {

    public Rigidbody obstacle;
    public float force;
    public bool left;
    public bool right;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (left)
        {
            obstacle.AddRelativeForce(Vector3.right * force);
            if (obstacle.position.x >= 1.0f)
            {
                left = false;
                right = true;
            }


        }
        if (right)
        {
            obstacle.AddRelativeForce(Vector3.left * force);
            if (obstacle.position.x <= -1.0f)
            {
                left = true;
                right = false;
            }
        }

    }
}
