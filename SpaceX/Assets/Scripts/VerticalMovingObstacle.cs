using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour{

    public Rigidbody obstacle;
    public float force;
    public bool up;
    public bool down;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (up)
        {
            obstacle.AddRelativeForce(Vector3.down * force );
            if (obstacle.position.y <= 2.2f)
            {
                up = false;
                down = true;
            }


        }
        if (down)
        {
            obstacle.AddRelativeForce(Vector3.up * force);
            if (obstacle.position.y >= 4.0f)
            {
                up = true;
                down = false;
            }
        }

    }
}
