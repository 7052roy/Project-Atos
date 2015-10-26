using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    public float objectSpeed = -0.5f;

    void Update()
    {
        transform.Translate(0, objectSpeed, 0);
    }
}