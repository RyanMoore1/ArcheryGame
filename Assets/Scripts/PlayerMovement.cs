using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f; //Controls velocity
    Rigidbody rb; //Tells script there is a rigidbody


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed;


    }
}
