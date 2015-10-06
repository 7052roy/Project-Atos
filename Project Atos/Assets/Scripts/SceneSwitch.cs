using UnityEngine;
using System.Collections;

public class SceneSwitch : MonoBehaviour {

    public Camera camera;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);

        if (Input.GetButton("Tap"))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("test");
                string name = hit.collider.gameObject.name;
                if (name == "Screen")
                {
                    Application.LoadLevel("liveFeed");
                }

                // Do something with the object that was hit by the raycast.
            }
        }
    }

}
