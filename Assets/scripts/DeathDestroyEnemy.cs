using UnityEngine;

public class DeathDestroyEnemy : DeathDestroy
{

    public AudioClip explosion;

    public override void Die()
    {
        GameManger.Instance.scorePlus();
        AudioSource.PlayClipAtPoint(explosion, transform.position);
        GameManger.Instance.numOfEnemys-= 1;
        //destroy the game object that this script is on
        base.Die();
        
    }

}
