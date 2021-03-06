using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + target.position, smoothSpeed);
        transform.position = newPos;
    }
}
