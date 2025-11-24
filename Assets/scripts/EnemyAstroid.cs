using UnityEngine;

public class EnemyAstroidDeath : DeathDestroyEnemy
{
    public GameObject nextAstroid;
    

    public int amountOfAstroids;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public override void Die()
    {
       
        SFXManger.Instance.expload();
        GameManger.Instance.numOfEnemys+= amountOfAstroids;
        for (int i = amountOfAstroids; i > 0; i--)
        {
            Instantiate(nextAstroid, new Vector3(Random.Range(transform.position.x-2, transform.position.x + 2), Random.Range(transform.position.y - 2, transform.position.y - 2), 0), Quaternion.identity);
        }


       
        base.Die();
        
    }

}
