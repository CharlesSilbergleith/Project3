using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  


    public void StartButton() { 
        SceneManager.LoadScene("playWorld");
        PlayerPrefs.SetFloat("currentScore", 0);


    }
    public void CreaditsButton() {
        SceneManager.LoadScene("Creadits");

    }


    public void Quit() {
        Application.Quit();
        Debug.Log("Quit");
    }


}
