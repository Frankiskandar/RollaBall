using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    private void Start() //gets callend script is run
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //input from keyboard?
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // dont want to move up so its 0


        rb.AddForce (movement * speed);


    }
}
