using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManger : MonoBehaviour
{
    public static UIManger Instance;
    public Image health;
    public TMP_Text score;
    public TMP_Text ammo;
    public TMP_Text Win;
    public TMP_Text Die;
    public TMP_Text Life;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

       
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManger.Instance.reset();
        ScreenUpdate();
        Win.enabled = false;
        Die.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
        ammo.text = "Ammo: " + GameManger.Instance.pawn.ammo + "/" + GameManger.Instance.pawn.ammoMax;
        health.fillAmount = GameManger.Instance.pawn.health.healthPercent;
    }
    public void ScreenUpdate() {
        score.text = "Score: " + GameManger.Instance.score;
        Life.text = "Life: "+ GameManger.Instance.lives;
    }
}
