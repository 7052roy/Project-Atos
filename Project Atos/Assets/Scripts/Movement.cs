using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = 0.5f;
    float location;


    // Update is called once per frame
    void Update () {
        transform.Translate(0,0,-speed);
        if(transform.position.z <= -40.0f)
        {
            transform.Translate(0,0,100);
        }
	}
}
