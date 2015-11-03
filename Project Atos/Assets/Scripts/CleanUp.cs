using UnityEngine;
using System.Collections;

public class CleanUp : MonoBehaviour {
	
	// Update is called once per frame, destroys objects if they get behind the player
	void Update () 
	{
		if (gameObject.transform.position.x < -55.0f) 
		{
			Destroy (gameObject);
		}
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstacle(Clone)")
        {
            Destroy (col.gameObject);
        }
    }
}
