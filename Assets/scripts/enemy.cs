using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    public Death death;
    //public AudioClip explosion;
    public AudioSource audioSource;
    
    
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() { 
         health = GetComponent<Health>();
        death = GetComponent<Death>();
        health.currentHealth = 10;
       
    }
    void Start()
    {
       
        
        audioSource = GetComponent<AudioSource>();
      

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (transform.position.x > GameManger.Instance.maxX+ 1 || transform.position.x < GameManger.Instance.minX - 1)
        {

            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }


      

    }
    
 
  
}
