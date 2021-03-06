﻿using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle;

    float timeElapsed = 0;
    float spawnCycle = 1f;
    bool spawnPowerup = true;


    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
            {
                temp = (GameObject)Instantiate(obstacle);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(pos.x, pos.y, pos.z);
            }

            spawnCycle = Random.Range(0.2f, 0.5f);
            timeElapsed -= spawnCycle;
            spawnPowerup = !spawnPowerup;
        }
    }
}
