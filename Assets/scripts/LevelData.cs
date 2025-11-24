using UnityEngine;
using System.Collections.Generic; 


public class LevelData : MonoBehaviour
{
    public static LevelData Instance;
    [Header("boundreies")]
    public float maxX;
    public float minX;
    public float maxY;
    public float maxZ;
    public float minZ;
    [Header("start Locations")]
    public startLocation pawnStart;
    public List<spawnPoint> spawnPoints = new List<spawnPoint>();
    public List<GameObject> powerUps = new List<GameObject>();
    public float minChance;
    public float maxChance;
    public float cutoff;
    private float randomInt;
    void Awake() {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        spawnPoints.Clear();


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < spawnPoints.Count; i++) {
            randomInt = Random.Range(minChance, maxChance);
            if (randomInt > cutoff) {
                spawnPoints[i].spawn();
            }
        }



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
