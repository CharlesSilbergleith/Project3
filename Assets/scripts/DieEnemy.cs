using UnityEngine;

public class DieEnemy : DeathDestroy
{
    public GameObject enemy;
    public bool isDuplactor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Die()
    {
        //destroy the game object that this script is on
            GameManger.Instance.numOfEnemys--;
            base.Die();
        
        
    }
}
