using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

    public Transform target;
    public Vector3 offset;
    public float smoothFactor;

    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
