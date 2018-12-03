using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject player;
    public GameObject obstaclePieces;
   // public AudioSource source;
    //public AudioClip clip;
   
  
    private float forwardForce = 2500f;
    private float sidewardForce = 4500f;

	// Use this for initialization
	void Start () {
       // source.clip = clip;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (player!=null && rb!=null)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.Force);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.Force);
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().score1.enabled = false;
                FindObjectOfType<GameManager>().GameOver();
                rb.useGravity = true;
            }
        }
        
    }
    float distZ = 0;
    //player collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
           // rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
            distZ = rb.position.z;
            Destroy(player);
            Destroy(rb);
            Instantiate(obstaclePieces, new Vector3(transform.position.x,transform.position.y,distZ),Quaternion.identity);
            //source.Play();
            FindObjectOfType<GameManager>().score1.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            
        }
    }
}
