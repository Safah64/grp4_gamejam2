using JetBrains.Annotations;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class cameraMovement : MonoBehaviour
{

    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 4f; // Smoothing speed for camera movement
    public Vector3 offset; // Offset from the player's position


  
   
    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
