using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /*public Transform target;
    public Vector3 offset;
    [Range(0, 10)]
    public float smoothFactor;*/

    public Transform target;
    public Vector3 offset;
    public float dumping;

    public Vector3 velocity = Vector3.zero;
    private void FixedUpdate()
    {
        //Follow();
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, dumping);
    }

    /*void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }*/
}
