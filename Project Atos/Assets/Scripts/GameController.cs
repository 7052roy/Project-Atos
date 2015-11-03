using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GameObject Hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float speed;
    public Rigidbody rb;


    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    //Creates waves of Hazard (obstacles), there is a set time between spawns and also between waves. It also gives them a spawning position and a velocity.
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        Vector3 movement = new Vector3(-speed, 0.0f, 0.0f);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(0f, (Random.Range(-6.5f, 10f)), -9f);
                Quaternion spawnRotation = new Quaternion(0, 0, 0, 0);
                GameObject newHazard = (GameObject)Instantiate(Hazard, spawnPosition, spawnRotation);
                newHazard.GetComponent<Rigidbody>().velocity = movement;
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}