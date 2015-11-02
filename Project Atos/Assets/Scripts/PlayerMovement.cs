using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Boundary boundary;
    private Rigidbody rb;
    private int Count;

    public class Boundary
    {
        public float yMin, yMax;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boundary = new Boundary();
        boundary.yMin = -5.5f;
        boundary.yMax = 10f;
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

       // Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f);

        //rb.AddForce(movement * speed);

       

        if (Input.GetButton("Jump") || Input.GetButton("Tab")) 
        {
            //print("up arrow key is held down");
            //transform.rotation = Quaternion.identity;
            //if (rb.position.y < (boundary.yMax - 1) && rb.position.y>(boundary.yMin-2))
            //{
                rb.AddForce(new Vector3(0f, speed, 0f));
            //} 
        }

        //rb.position = new Vector3
      //(
          //rb.position.x,
          //Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),
          //rb.position.z
      //);
    }
}
