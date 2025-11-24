using UnityEngine;
using UnityEngine.SceneManagement;


public class CreadtisRoll : MonoBehaviour
{
    public GameObject creadits;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
     public float timeLeft = 20f; // seconds

    void Update()
    {
        timeLeft -= Time.deltaTime; // decrease time each frame

        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene("MainMenu");
            timeLeft = 0f;
            // do something, like load a new scene or trigger an event
        }

    }
}
