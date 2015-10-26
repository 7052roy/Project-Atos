using UnityEngine;
using System.Collections;

public class BreakSpring : MonoBehaviour {

    float elapsedTime;
	
	// Update is called once per frame
	void Update () {
        elapsedTime -= Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "Marble" || other.gameObject.name == "Sphere(Clone)")
        {
            if (elapsedTime < 0)
            {
                elapsedTime = 5;
            }
            else if (elapsedTime <= 1)
            {
                DestroyObject(gameObject);
            }
        }
    }
}
