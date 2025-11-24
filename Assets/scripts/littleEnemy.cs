using UnityEngine;

public class littleEnemy : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position +=  new Vector3(Random.Range(1, 4), Random.Range(1, 2), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
