using UnityEngine;

public class powerUpPoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabToSpawn;
    void Awake()
    {
        LevelData.Instance.powerUps.Add(this.gameObject);


    }
    public void spawn()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
        GameManger.Instance.powerUps++;
    }


}
