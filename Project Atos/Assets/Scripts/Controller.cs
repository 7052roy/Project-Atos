using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    private Rigidbody controller;
    public float speed = 10.0f;
    public float jumpSpeed = 15.0f;
    float timeElapsed;
    bool jump = false;
    int count;
    public Text countText;


    //start 
    void Start()
    {
        //controller = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "score: " + count.ToString();
        

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        //Debug.Log(timeElapsed);
        if ((Input.GetButton("Tap") || Input.GetButton("Jump")) && transform.position.y < 3 && jump == false)
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
        
        if (timeElapsed >= 1f)
        {
            
            count++;
            countText.text = "score: " + count.ToString();
            timeElapsed = 0;
        }


    }

    //check if the character collects the powerups or the snags
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Obstacle(Clone)")
        {
            PlayerPrefs.SetString("player", "player: " + count.ToString());
            Application.LoadLevel("Security room");
        }
        Destroy(other.gameObject);            //destroy the snag or powerup if colllected by the player

    }
}