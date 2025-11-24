using UnityEngine;
using UnityEngine.UI;


public class WorldSpaceHeathBar : MonoBehaviour
{
    [SerializeField]  private Slider slider; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Updatehealthbar(float currnet, float max) {
        slider.value = currnet / max;
       }
}
