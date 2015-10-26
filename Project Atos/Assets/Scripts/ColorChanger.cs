using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {


    public Light lt;
    // Use this for initialization
    void Start () {
        lt = GetComponent<Light>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Marble" || other.gameObject.name == "Sphere(Clone)")
        {
            lt.color = Color.blue;
        }

    }
}
