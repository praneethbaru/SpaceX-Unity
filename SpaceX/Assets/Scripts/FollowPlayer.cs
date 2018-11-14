using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform cameraPos;
    public Vector3 offset;
	// Update is called once per frame
	void Update () {
        transform.position = cameraPos.position + offset;
        
	}
}
