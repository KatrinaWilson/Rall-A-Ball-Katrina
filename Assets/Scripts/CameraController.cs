using UnityEngine; 
using System;

public class CameraController : MonoBehaviour
{
    public GameObject player; // public to asign the player to this variable in the inspector 
    Vector3 offset; // empty Vector3 to store the starting position of the camera 

    void Start()
    {
        offset = transform.position; // store the cameras starting position so we can keep the same offset as the ball moves 
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // updates the camera's postion as the ball moves 
    }
}