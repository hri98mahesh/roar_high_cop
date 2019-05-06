using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIGERMOVER : MonoBehaviour
{
    
    public float speed;             //Floating point variable to store the player's movement speed.
    //private Transform tr;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D> ();
        
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
       // tr = GetComponent<Transform>();
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Store the current vertical input in the float moveVertical.

        Vector2 pos = gameObject.transform.position;
        //  if (pos.y <= (float)(9.4))
        //{
        //  pos.y = (float)(9.5);
        // gameObject.transform.position = pos;
        //}
        if (rb2d.velocity.y == (float)(0.0))
        {
            if (Input.GetAxis("Horizontal") >= 0 && Input.GetAxis("Vertical") >= 0)
                rb2d.velocity = new Vector2(speed * Input.GetAxis("Horizontal"),speed * Input.GetAxis("Vertical"));
            else if (Input.GetAxis("Horizontal") <= 0 && Input.GetAxis("Vertical") >= 0)
                rb2d.velocity = new Vector2((float)0.0,speed * Input.GetAxis("Vertical"));
            else if (Input.GetAxis("Horizontal") >= 0 && Input.GetAxis("Vertical") <= 0)
                rb2d.velocity = new Vector2(speed * Input.GetAxis("Horizontal"),(float)0.0);

        }
        //Use the two store floats to create a new Vector2 variable movement.

    }

}
