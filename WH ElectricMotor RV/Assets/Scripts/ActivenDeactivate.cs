using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivenDeactivate : MonoBehaviour
{
    public Rotation myRotation;
    public Rotation myRotationY;
    public AudioSource myAudio;
    public AudioSource myAudio2;




    public void Move ()
    {
        myRotationY.enabled = true;
        myRotation.enabled = false;
        myAudio2.enabled = true;
        myAudio.enabled = false;
    }

    public void Moveminus()
    {
        
        myRotationY.enabled = false;
        myRotation.enabled = true;
        myAudio2.enabled = false;
        myAudio.enabled = true;
    }

    public void NoMove()
    {
        myRotationY.enabled = false;
        myRotation.enabled = false;
        myAudio2.enabled = false;
        myAudio.enabled = false;
    }
}
