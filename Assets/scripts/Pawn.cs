using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("pawn")]
    public GameObject pawn;
    [Header("movement settings ")]
    public float moveForce;
    public float yawSpeed;
    public float rollSpeed;
    public float pitchSpeed;
    public float drag;

    [Header("rigidbody")]
    public Rigidbody rb;
    [Header("Componets")]
    public Health health;
    public Death death;
    [Header("Shooting")]

    public GameObject Bullet;

    public int ammo;
    public int ammoMax;
    [Header("Sound")]
    public AudioClip lasaerSound;
    public AudioClip Warp;

    public AudioSource audioSource;





    void Awake() {
        zero();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearDamping = drag;
        health = GetComponent<Health>();
        death = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        checkBoundries();
        // Check if object fell below Y = 0
        if (transform.position.y < 0)
        {
            // Reset position to X = 0, Y = 20, keep Z the same (or set Z = 0)
            transform.position = new Vector3(0f, 20f, transform.position.z);

            // Optional: reset velocity if using Rigidbody
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }




    public void moveForward()
    {
        rb.AddForce(transform.forward * moveForce, ForceMode.Force);
    }


    public void moveBackWards()
    {
        rb.AddForce(-transform.forward * moveForce, ForceMode.Force);
    }
    public void moveRight()
    {
        Vector3 right = Vector3.up * yawSpeed * Time.deltaTime;
        updateMovement(right);
    }

    public void moveLeft()
    {
        Vector3 left = -Vector3.up * yawSpeed * Time.deltaTime;
        updateMovement(left);

    }


    


    public void rollRight()
    {
        Vector3 up = Vector3.forward * rollSpeed * Time.deltaTime;
        updateMovement(up);

    }


    public void rollleft()
    {

        Vector3 down = -Vector3.forward * rollSpeed * Time.deltaTime;
        updateMovement(down);





    }


    public void moveUp()
    {

        Vector3 right = Vector3.right * pitchSpeed * Time.deltaTime;
        updateMovement(right);
    }


    public void moveDown()
    {


        Vector3 left = -Vector3.right * pitchSpeed * Time.deltaTime;
        updateMovement(left);


    }

    public void updateMovement(Vector3 vector)
    {
        transform.Rotate(vector, Space.Self);
    }

    public void Shoot()
    {
        if (ammo != 0)
        {
            Instantiate(Bullet, pawn.transform.position + transform.up, pawn.transform.rotation);
            ammo -= 1;
            SFXManger.Instance.shoot();
        }
        //Debug.Log("Shoot");
    }
    public void Reload()
    {
        ammo = ammoMax;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        UFO otherUFO = other.gameObject.GetComponent<UFO>();
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherUFO != null)
        {
            otherHealth.TakeDamage(otherHealth.maxHealth);
        }




    }
    public void checkDistance() {
        if (transform.position.x > LevelData.Instance.maxX)
        {
            transform.position = new Vector3(
               LevelData.Instance.maxX,//changed var
                transform.position.y, // current Y
                transform.position.z //current Z
            );
        } 
        else

        if (transform.position.x < LevelData.Instance.minX)
        {
            transform.position = new Vector3(
               LevelData.Instance.minX,//changed var
                transform.position.y, // current Y
                transform.position.z //current Z
            );
        }
    }
    public void checkZed() {
        if (transform.position.z > LevelData.Instance.maxZ)
        {
            transform.position = new Vector3(
               transform.position.z ,//changed var
                transform.position.y, // current Y
                 LevelData.Instance.maxZ//current Z
            );
        }
        else

        if (transform.position.z < LevelData.Instance.minZ)
        {
            transform.position = new Vector3(
              transform.position.z,//changed var
                transform.position.y, // current Y
                 LevelData.Instance.minZ//current Z
            );
        }
    }
    public void checkHight()
    {
        if (transform.position.y > LevelData.Instance.maxY)
        {
            transform.position = new Vector3(
                transform.position.x,//curent x
                LevelData.Instance.maxY,//changed var 
                transform.position.z//currnet z
            );
        }
    }
    public void checkBoundries() {
        checkHight();
        checkDistance();
        checkZed();
    }
    public void zero() {
        transform.position = LevelData.Instance.pawnStart.transform.position;
    }


}
