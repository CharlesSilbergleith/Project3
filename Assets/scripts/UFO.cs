using UnityEngine;

public class UFO : Enemy
{

    public Transform pawn;   // Assign the player pawn here
    public float speed = 10f;
    public float rotateSpeed = 5f;

    void Start()
    {
        if (pawn == null)
        {
            GameObject pawnObj = GameObject.Find("Pawn");
            if (pawnObj != null)
                pawn = pawnObj.transform;
        }
    }

    void Update()
    {
        transform.LookAt(pawn);
        homeIn();


    }
    public void homeIn()
    {



        if (pawn == null) return;

        // Direction to target
        Vector3 direction = (pawn.position - transform.position).normalized;

        // Rotate toward the target
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

        // Move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}


