using UnityEngine;
using UnityEngine.InputSystem; // Only needed if using the new input system

public class ShipCameraFollow : MonoBehaviour
{
    public Transform target;     // The object the camera follows
    public Vector3 offset;       // Position offset from the target
    public Vector3 rotationOffset; // Rotation offset (if needed)

  
    void LateUpdate()
    {
        transform.position = target.position + target.TransformDirection(offset);
        transform.rotation = target.rotation;
    }

}
