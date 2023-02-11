using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChange : MonoBehaviour
{
   public GameObject cam1;
   public GameObject cam2;
   public GameObject cam3;

    public void Previous()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
    }

    public void Back()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
    }
    
    public void Next()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
    }
}

