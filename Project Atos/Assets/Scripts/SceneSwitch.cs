using UnityEngine;
using System.Collections;

public class SceneSwitch : MonoBehaviour {

    public Camera camera;
    public TextMesh text;


    void Start()
    {
        text.text = PlayerPrefs.GetString("player");
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);

        if (Input.GetButton("Tap") || Input.GetButton("Jump"))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("test");
                string name = hit.collider.gameObject.name;
                if (name == "Screen")
                {
                    Application.LoadLevel("LiveFeed");
                }
                if (name == "Screen2")
                {
                    Application.LoadLevel("Course");
                }
                if (name == "Screen3")
                {
                    Application.LoadLevel("LiveFeed 1");
                }
                if (name == "Door")
                {
                    Application.LoadLevel("runner");
                }

                // Do something with the object that was hit by the raycast.
            }
        }
    }

}
