using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothspeed = 0.125f;

    void LateUpdate()
    {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredposition, smoothspeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
