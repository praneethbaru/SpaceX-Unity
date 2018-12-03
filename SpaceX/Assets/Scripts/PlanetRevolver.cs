using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRevolver : MonoBehaviour {
    public float speed;
    public int x;
    public int y;
    public int z;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x * speed, y * speed, z * speed);
    }
}
