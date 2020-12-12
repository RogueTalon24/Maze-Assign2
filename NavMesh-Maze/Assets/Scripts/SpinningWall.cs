using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Jesus Papania

public class SpinningWall : MonoBehaviour
{

    public Rigidbody rb;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        //if collision is player
        if (other.gameObject.tag == "Player") {
            rb.AddForce(thrust, thrust / 2, thrust, ForceMode.Impulse);
        }
    }
}
