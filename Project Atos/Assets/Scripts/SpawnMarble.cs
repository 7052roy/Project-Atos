using UnityEngine;
using System.Collections;

public class SpawnMarble : MonoBehaviour {

    public GameObject marble2;
    public GameObject marble3;
    public GameObject mainMarble;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Marble")
        {
            Instantiate(marble2);
            marble2.transform.position = new Vector3(mainMarble.transform.position.x - 7, mainMarble.transform.position.y + 3,mainMarble.transform.position.z + 0.6f);
            Instantiate(marble3);
            marble3.transform.position = new Vector3(mainMarble.transform.position.x  - 7, mainMarble.transform.position.y + 3, mainMarble.transform.position.z - 0.6f);
        }

    }
}
