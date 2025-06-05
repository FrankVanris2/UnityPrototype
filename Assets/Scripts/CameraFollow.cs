/**
 * CameraFollow.cs
 * By: Frank Vanris
 * This script allows the camera to follow a target object in Unity.
 * The target is assigned through the Inspector.
 */

using System.Collections.Specialized;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // Assigning my player here in the Inspector
    [SerializeField] float height = 120f; // Height above the target
    [SerializeField] float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        
        Vector3 desiredPosition = target.position + Vector3.up * height;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        
    }
}
