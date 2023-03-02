using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChange : MonoBehaviour
{
   public GameObject camFleacha;
   public GameObject camCarcasa;
   public GameObject camMesa;
   public GameObject camBackCap;
   public GameObject camFrontCap;
   public GameObject camEstator;
   public GameObject camRotor;
   public GameObject camVentilador;
   public GameObject camBobinas;
   public GameObject camBaleros;
   public GameObject camRetBaleros;
   public GameObject camCajaConex;
    //These are the explanations not the geometry of the piece
   public GameObject flecha;
   public GameObject carcasa;
   public GameObject backcap;
   public GameObject frontcap;
   public GameObject estator;
   public GameObject rotor;
   public GameObject ventilador;
   public GameObject bobinas;
   public GameObject baleros;
   public GameObject retBaleros;
   public GameObject conBox;



    public void Flecha()
    {
        camFleacha.SetActive(true);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(true);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Carcasa()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(true);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(true);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Mesa()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(true);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Backcap()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(true);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(true);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Frontcap()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(true);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(true);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Estator()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(true);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(true);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Rotor()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(true);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(true);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Ventilador()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(true);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(true);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Bobinas()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(true);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(true);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void Baleros()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(true);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(true);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(true);
        retBaleros.SetActive(false);
        conBox.SetActive(false);
    }

    public void RetBaleros()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(true);
        camCajaConex.SetActive(false);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(true);
        conBox.SetActive(false);
    }

    public void ConBox()
    {
        camFleacha.SetActive(false);
        camCarcasa.SetActive(false);
        camMesa.SetActive(false);
        camBackCap.SetActive(false);
        camFrontCap.SetActive(false);
        camEstator.SetActive(false);
        camRotor.SetActive(false);
        camVentilador.SetActive(false);
        camBobinas.SetActive(false);
        camBaleros.SetActive(false);
        camRetBaleros.SetActive(false);
        camCajaConex.SetActive(true);

        flecha.SetActive(false);
        carcasa.SetActive(false);
        backcap.SetActive(false);
        frontcap.SetActive(false);
        estator.SetActive(false);
        rotor.SetActive(false);
        ventilador.SetActive(false);
        bobinas.SetActive(false);
        baleros.SetActive(false);
        retBaleros.SetActive(false);
        conBox.SetActive(true);
    }

}

