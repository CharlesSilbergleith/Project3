using UnityEngine;

public class Controller : MonoBehaviour
{
   
    

    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Application Quit!");
        }
        //calls the function every frame to see what the inputs are
        if (pawn != null)
        {
            makeDesisions();
        }
    }

    public void makeDesisions() {

        if (Input.GetKey(KeyCode.W)) {
            pawn.moveForward();
        }
        if (Input.GetKey(KeyCode.S)) {
            pawn.moveBackWards();
        }
        if (Input.GetKey(KeyCode.A)) {
            pawn.moveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            pawn.moveRight();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            pawn.rollRight();
        }
        if (Input.GetKey(KeyCode.E))
        {
            pawn.rollleft(); 
        }
        if (Input.GetKey(KeyCode.Z))
        {
            pawn.moveUp();
        }
        if (Input.GetKey(KeyCode.X))
        {
            pawn.moveDown();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pawn.Shoot();

        }
        if (Input.GetKeyDown(KeyCode.R)) {
            pawn.Reload();
        
        }



    }



}
