using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    private float moveX;

    private void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, moveX * rotateSpeed * Time.deltaTime, 0);
        }
    }
}
