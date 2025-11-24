using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject prefabToSpawn;
    void Awake() {
        LevelData.Instance.spawnPoints.Add(this);


    }
    public void spawn()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
        GameManger.Instance.numOfEnemys++;
    }

}
