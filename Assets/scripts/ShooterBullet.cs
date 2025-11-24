using UnityEngine;

public class ShooterBullet : MonoBehaviour
{
    public float ShootSpeed = 20f;
    public float damage = 10f;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody missing on bullet prefab!");
            return;
        }

        // Move bullet forward immediately
        rb.linearVelocity = transform.forward * ShootSpeed;

        // Optional: destroy after 5 seconds to avoid clutter
        Destroy(gameObject, 5f);
    }

    void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damage);
        }

        // Destroy bullet on hit
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
