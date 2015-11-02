using UnityEngine;
using System.Collections;

public class PlayerCollisionDetection : MonoBehaviour
{

    //public GUIText scoreText;
    public int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        UpdateScore();

        Debug.Log("started");
    }

    void OnCollisionEnter(Collision col) // if player collides with a collectable, the collectable gets destroyed and the ups the score with 1.
    {
        if (col.gameObject.name == "Collectable(Clone)")
        {
            Destroy(col.gameObject);
            AddScore(1);
        }

        if (col.gameObject.name == "Obstacle(Clone)") // Stops the game if the player hits an obstacle
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void AddScore(int newScoreValue) // calls on update score and adds 1 to the old score
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        //scoreText.text = "Score: " + score;
    }
}
