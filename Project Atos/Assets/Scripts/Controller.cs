using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    private Rigidbody controller;
    public float speed = 15.0f;
    public float jumpSpeed = 15.0f;
    float timeElapsed;
    bool jump = false;

    //start 
    void Start()
    {
        //controller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Tap") && transform.position.y < 3 && jump == false)
        {
            transform.Translate(0f, 0.1f, 0f);
            if(transform.position.y > 2.9f)
            {
                jump = true;
            }

        }else if(transform.position.y > 1)
        {
            transform.Translate(0f, -0.1f, 0f);
            if(jump && transform.position.y < 1.1f)
            {
                jump = false;
            }
        }
    }

    //check if the character collects the powerups or the snags
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Obstacle(Clone)")
        {
            Application.LoadLevel("Security room");
        }
        Destroy(other.gameObject);            //destroy the snag or powerup if colllected by the player

    }
}