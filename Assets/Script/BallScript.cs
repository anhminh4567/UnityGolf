using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float dragMultiplier = 0.1f;
    public Rigidbody2D rigidBody;
    public BallScript()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.velocity != Vector2.zero)
        {
            rigidBody.AddForce(-(rigidBody.velocity * dragMultiplier));
              //sdfdsf
        }
    }
}
