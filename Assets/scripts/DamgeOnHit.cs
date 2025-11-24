using UnityEngine;

public class DamgeOnHit : MonoBehaviour
{
    public bool InstaDeath;
    public AudioClip takeDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        Pawn otherPawn = other.gameObject.GetComponent<Pawn>();
        UFO otherUFO = other.gameObject.GetComponent<UFO>();
        
        if (InstaDeath)
        {
            if (otherHealth != null && otherPawn != null )
            {
                otherHealth.TakeDamage(otherHealth.maxHealth);
                UIManger.Instance.ScreenUpdate();
            }
        }
        else
        {
            //Health otherHealth = other.gameObject.GetComponent<Health>();
            if (otherHealth != null && otherPawn != null)
            {

                otherHealth.TakeDamage(1);
                SFXManger.Instance.pawnTakeDamage();
                UIManger.Instance.ScreenUpdate();
            }
        }
        


    }




}
