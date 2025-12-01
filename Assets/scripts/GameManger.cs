using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    [Header("pawn/controller")]
    public Pawn pawn;
    public Controller controller;
    [Header("enemy")]
    
    public float numOfEnemys;
    [Header("win Con")]
    public float lives;
    public bool win;
    public float score;
    public float powerUps;
    [Header("boundreies")]
    public float maxX;
    public float minX;
    public float maxY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        


        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }


        lives = 3;
        score = PlayerPrefs.GetFloat("currentScore", 0);

    }
       
    

        
       


    void Start()
    {
        UIManger.Instance.ScreenUpdate();

        

    }

    // Update is called once per frame
    void Update()
    {
        if (numOfEnemys == 0) {
            gameWin();
            gameEnd();
        }
        if (lives <= 0) {
            gameLose();
            gameEnd();
        }
        if (pawn == null) { 
            //Instantiate(pawn, Vector3.zero, Quaternion.identity);
            
        }

        
    }
    public void gameEnd()
    {
        Debug.Log("End");
        StartCoroutine(LoadNextSceneAfterDelay(3f));
    }

    
    private IEnumerator LoadNextSceneAfterDelay(float delay)
    {

        Time.timeScale = 0f;

        // Wait 3 real seconds (unaffected by pause)
        yield return new WaitForSecondsRealtime(delay);

        // Restore normal time before switching scenes
        Time.timeScale = 1f;

        // Load next scene
        if (!win)
        {
        SceneManager.LoadScene("MainMenu");
        }
        else { 
           SceneManager.LoadScene("playWorld");
        }

           
    }
    

    void gameWin() {
        UIManger.Instance.Win.enabled = true;
        win = true;
        PlayerPrefs.SetFloat("currentScore", score);
        Debug.Log("You WIn good job..... reword...... what wining not enough.... greedy");
    }
    public void gameLose() {
        UIManger.Instance.Die.enabled = true;
        win = false;
        Debug.Log("HA you suck... like holy shit that was bad..... do better");
        score = 0;
        lives = 3;
        PlayerPrefs.SetFloat("currentScore", 0);

    }
   
    public void scorePlus() {
        score++;
        checkHighScore();
        UIManger.Instance.ScreenUpdate();
    }
    public void scorePlus(int value)
    {
        score+= value;
        UIManger.Instance.ScreenUpdate();
    }
    public void checkHighScore() {
        if (score > PlayerPrefs.GetFloat("highScore",0))
        {
            PlayerPrefs.SetFloat("highScore", score);
        }
    }
}
