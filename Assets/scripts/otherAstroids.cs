using UnityEngine;

public class otherAstroids : MonoBehaviour
{
    public Health health;
    public Death death;
    //public AudioClip explosion;
    public AudioSource audioSource;
    
    private int random;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        health = GetComponent<Health>();
        death = GetComponent<Death>();
        health.currentHealth = 10;
        random = Random.Range(1, 10);
    }
    void Start()
    {

  
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        if (random > 5)
        {
            transform.position += (transform.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position += (-transform.right * moveSpeed * Time.deltaTime);

        }
        if (transform.position.x > 11f || transform.position.x < -11f)
        {

            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 6f || transform.position.y < -6f)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        }

    }
   

}

