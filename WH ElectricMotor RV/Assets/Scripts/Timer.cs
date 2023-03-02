using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public GameObject BackCapButton;
    public GameObject TableButton;
    public GameObject RotorButton;
    public GameObject FrontCapButton;
    public GameObject EstatorButton;
    public GameObject ConBoxButton;
    public GameObject VentiladorButton;
    public GameObject BobinasButton;
    public GameObject BalerosButton;
    public GameObject RetBalerosButton;
    public GameObject FlechaButton;
    public GameObject CarcasaButton;

    public void Disappear()
    {
        BackCapButton.SetActive(false);
        TableButton.SetActive(false);
        RotorButton.SetActive(false);
        FrontCapButton.SetActive(false);
        EstatorButton.SetActive(false);
        ConBoxButton.SetActive(false);
        VentiladorButton.SetActive(false);
        BobinasButton.SetActive(false);
        BalerosButton.SetActive(false);
        RetBalerosButton.SetActive(false);
        FlechaButton.SetActive(false);
        CarcasaButton.SetActive(false);
        StartCoroutine(ButtonCoroutine());
    }

    IEnumerator ButtonCoroutine()
    {
        yield return new WaitForSeconds(3f);
        // Turn on the button & make it active
        BackCapButton.SetActive(true);
        TableButton.SetActive(true);
        RotorButton.SetActive(true);
        FrontCapButton.SetActive(true);
        EstatorButton.SetActive(true);
        ConBoxButton.SetActive(true);
        VentiladorButton.SetActive(true);
        BobinasButton.SetActive(true);
        BalerosButton.SetActive(true);
        RetBalerosButton.SetActive(true);
        FlechaButton.SetActive(true);
        CarcasaButton.SetActive(true);
    }

    
}
