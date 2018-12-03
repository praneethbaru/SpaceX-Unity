using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;
    public GameObject obstaclePieces;

    void OnCollisionEnter(Collision collision)      
    {

        if (collision.collider.tag == "Obstacle")
        {
            // playerMovement.enabled = false;
            // Debug.Log("collision");
            Destroy(playerMovement);
            Instantiate(obstaclePieces, transform.position, transform.rotation);
            FindObjectOfType<GameManager>().GameOver();
        }      
    }
}
