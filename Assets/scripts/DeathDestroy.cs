using UnityEngine;

public class DeathDestroy : Death
{
    
    public override void Die()
    {
        //destroy the game object that this script is on
        Destroy(gameObject);
    }



}
