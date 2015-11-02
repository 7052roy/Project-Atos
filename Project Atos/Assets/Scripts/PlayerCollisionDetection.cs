using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollisionDetection : MonoBehaviour
{

    //public GUIText scoreText;
    public int score;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        score = 0;
        scoreText.text = "Score; " + score.ToString();
    }

    void OnCollisionEnter(Collision col) // if player collides with a collectable, the collectable gets destroyed and the ups the score with 1.
    {
        if (col.gameObject.name == "Collectable(Clone)")
        {
            Destroy(col.gameObject);
            score++;
            scoreText.text = "Score; " + score.ToString();
        }

        if (col.gameObject.name == "Obstacle(Clone)") // Stops the game if the player hits an obstacle
        {
            if(PlayerPrefs.GetString("Jetpack") != null)
            {
                Debug.Log("testing");
                if(PlayerPrefs.GetInt("Jetpack2") <= score)
                {
                    PlayerPrefs.SetString("Jetpack", "Jetpack: " + score.ToString());
                    PlayerPrefs.SetInt("Jetpack2", score);
                }
            }
            else
            {
                PlayerPrefs.SetString("Jetpack", "Jetpack: " + score.ToString());
                PlayerPrefs.SetInt("Jetpack2", score);
            }

            //PlayerPrefs.SetString("Jetpack", "Jetpack: " + score.ToString());
           // PlayerPrefs.SetInt("Jetpack2", score);
            Application.LoadLevel("Security room");
        }
    }
}
