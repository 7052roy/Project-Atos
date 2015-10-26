using UnityEngine;
using System.Collections;

public class ActivateGravity : MonoBehaviour {


    Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        rb.useGravity = true;

    }
}
