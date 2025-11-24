using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public KeyCode inputkey;
    public Color newcolor;
    public Transform location;
    //public Vector2 spriteLocation;
    public int randomRangeX1;
    public int randomRangeY1;
    public int randomRangeX2;
    public int randomRangeY2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set the veriblae made in the begining and allow for input for desighner 
        spriteRender = GetComponent<SpriteRenderer>();
        //inputkey = KeyCode.A;
        location = GetComponent<Transform>();

        if (spriteRender != null)
        {
            spriteRender.color = Color.white;
           
        }
        randomRangeX1 = 10;
        randomRangeY1 = 4;
        randomRangeX2 = -10;
        randomRangeY2 = -4;



    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
            Debug.Log("Application Quit!");
        }
        //when a key is pressed down move the object to a random postion
        //make escape key funciton
        if (Input.GetKeyDown(inputkey))
        {
            location.position = new Vector3(Random.Range(randomRangeX1, randomRangeX2), Random.Range(randomRangeY1, randomRangeY2), 0);
            
        }
  



    }
}
