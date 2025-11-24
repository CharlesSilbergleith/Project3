using UnityEngine;

public class DamgeOnOverlap : MonoBehaviour
{
    public float damgeDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null) {
            otherHealth.TakeDamage(damgeDone);
        }
    }
}
