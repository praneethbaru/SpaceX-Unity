using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneCameraMovement : MonoBehaviour {

    // public Transform cameraPos;
   // public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * 10);

    }
}
