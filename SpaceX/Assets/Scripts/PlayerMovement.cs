using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewardForce = 500f;

    //public Transform player;
	// Use this for initialization
	void Start () {
        //rb.useGravity = false;
        Debug.Log("Game started");

	}
	
	// Update is called once per frame
	void FixedUpdate () {

       
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewardForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
            rb.useGravity = true;
        }
    }

}
