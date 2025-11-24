using UnityEngine;

public class healthPack : MonoBehaviour
{
    public AudioClip HealthSound;
    public AudioSource audioSource;

    public float healAmount;
    void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        Pawn otherPawn = other.gameObject.GetComponent<Pawn>();
       
            if (otherHealth != null && otherPawn != null)
        {
            Debug.Log("Heal");

            otherHealth.Heal(healAmount);
            AudioSource.PlayClipAtPoint(HealthSound, transform.position);
            UIManger.Instance.ScreenUpdate();
                Destroy(gameObject);


        }
        
       


    }
}
