using UnityEngine;

public class DeathRecenter : Death
{
    public override void Die()
    {
        //set game object to 0,0,0
        transform.position = Vector3.zero;


      

    }




}
