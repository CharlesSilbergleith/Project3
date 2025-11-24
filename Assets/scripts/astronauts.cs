using UnityEngine;

public class astronauts : MonoBehaviour
{
    public AudioClip pointsSound;
    public AudioSource audioSource;

    public float points;
    void OnTriggerEnter(Collider other)
    {
        
        Pawn otherPawn = other.gameObject.GetComponent<Pawn>();

        if (otherPawn != null)
        {
            GameManger.Instance.score+= points;

            AudioSource.PlayClipAtPoint(pointsSound,transform.position);
            UIManger.Instance.ScreenUpdate();
            Destroy(gameObject);


        }

    }
}
