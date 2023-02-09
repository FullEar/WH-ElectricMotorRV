using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
   void Update()
    {
        transform.Rotate(rotateSpeed * Input.GetAxis("Vertical"), rotateSpeed * -(Input.GetAxis("Horizontal")), 0);
    }
}
