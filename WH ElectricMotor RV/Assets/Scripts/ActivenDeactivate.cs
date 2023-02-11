using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivenDeactivate : MonoBehaviour
{
    public Rotation myRotation;
    public Rotation myRotationY;





    public void Move ()
    {
        myRotationY.enabled = true;
        myRotation.enabled = false;  
        
    }

    public void Moveminus()
    {
        myRotation.enabled = true;
        myRotationY.enabled = false;
    }

    public void NoMove()
    {
        myRotationY.enabled = false;
        myRotation.enabled = false;
    }
}
