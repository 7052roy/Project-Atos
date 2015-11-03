using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour
{

    public GameObject collectable;
    public Vector3 spawnValues;
    public int collectableCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float speed;
    private Rigidbody rb;
    private Color32[] olympicColors = new Color32[5];

    void Start()
    {
        StartCoroutine(SpawnWaves());
        olympicColors[0] = new Color32(0, 102, 124, 255);
        olympicColors[1] = new Color32(243, 182, 77, 255);
        olympicColors[2] = new Color32(4, 0, 0, 255);
        olympicColors[3] = new Color32(0, 165, 42, 255);
        olympicColors[4] = new Color32(223, 53, 74, 255);
    }

    //Creates waves of collectables, there is a set time between spawns and also between waves. It also gives them a spawning position and a velocity.
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        Vector3 movement = new Vector3(-speed, 0.0f, 0.0f);
        while (true)
        {
            for (int i = 0; i < collectableCount; i++)
            {
                Vector3 spawnPosition = new Vector3(0f, (Random.Range(-5.5f, 10f)), -9f);
                Quaternion spawnRotation = new Quaternion(180, 180, 90, 0);
                GameObject newHazard = (GameObject)Instantiate(collectable, spawnPosition, spawnRotation);
                newHazard.GetComponent<Rigidbody>().velocity = movement;
                Renderer renderer = newHazard.GetComponent<Renderer>();

                renderer.material.color = olympicColors[Random.Range(0, 5)];
                
                yield return new WaitForSeconds(spawnWait);

            }
            yield return new WaitForSeconds(waveWait);
        }
    }


}
