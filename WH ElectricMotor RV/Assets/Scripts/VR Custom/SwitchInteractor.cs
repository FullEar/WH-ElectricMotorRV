using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SwitchInteractor : MonoBehaviour
{
    public GameObject lRayInteractor;

    public GameObject rRayInteractor;

    public GameObject lDirectInteractor;

    public GameObject rDirectInteractor;

    public InputActionReference lswitch;
    public InputActionReference rswitch;

    private bool rdirect = true;

    private bool ldirect = true;
    // Start is called before the first frame update
    void Start()
    {
        lDirectInteractor.SetActive(true);
        rDirectInteractor.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
       // RInteractorSwitch();
       // LInteractorSwitch();
       if (lswitch.action.IsPressed() && ldirect == true)
       {
           lDirectInteractor.SetActive(false);
           lRayInteractor.SetActive(true);
           ldirect = false;
           Debug.Log("desactivado direct l");
       }
       else if (lswitch.action.IsPressed() && ldirect == false)
       {
           lDirectInteractor.SetActive(true);
           lRayInteractor.SetActive(false);
           ldirect = true;
           Debug.Log("activado direct l");

       }
       
       if (rswitch.action.WasPressedThisFrame() && rdirect == true)
       {
           rDirectInteractor.SetActive(false);
           rRayInteractor.SetActive(true);
           rdirect = false;
       }
       else if (rswitch.action.WasPressedThisFrame() && rdirect == false)
       {
           rDirectInteractor.SetActive(true);
           rRayInteractor.SetActive(false);
           rdirect = true;

       }
    }

    public void LInteractorSwitch()
    {
        if (lswitch.action.IsPressed() && ldirect == true)
        {
            lDirectInteractor.SetActive(false);
            lRayInteractor.SetActive(true);
            ldirect = false;
            Debug.Log("desactivado direct l");
        }
        else if (lswitch.action.IsPressed() && ldirect == false)
        {
            lDirectInteractor.SetActive(true);
            lRayInteractor.SetActive(false);
            ldirect = true;
            Debug.Log("activado direct l");

        }
    }

    public void RInteractorSwitch()
        {
            if (rswitch.action.WasPressedThisFrame() && rdirect == true)
            {
                rDirectInteractor.SetActive(false);
                rRayInteractor.SetActive(true);
                rdirect = false;
            }
            else if (rswitch.action.WasPressedThisFrame() && rdirect == false)
            {
                rDirectInteractor.SetActive(true);
                rRayInteractor.SetActive(false);
                rdirect = true;

            }
        }
    
}
