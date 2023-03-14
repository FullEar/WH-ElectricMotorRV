using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Register : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public InputField EmailInput;
    public InputField DayInput;
    public InputField MonthInput;
    public InputField YearInput;
    public InputField NameInput;
    public InputField LastnameInput;
    public Dropdown sexlist;
    public Button RegisterBB;
   


    void Start()
    {
        
        RegisterBB.onClick.AddListener(() =>
        {
            string Sexinput = "";
            if (sexlist.value == 1)
            {
                Sexinput = "Hombre";
            }
            else if (sexlist.value == 2)
            {
                Sexinput = "Mujer";
            }
            else
            {
                Sexinput = "";
            }
            Debug.Log(Sexinput);
            
            StartCoroutine(MainWeb.Instance.WebRequest.RegisterUser(UsernameInput.text, PasswordInput.text, EmailInput.text, DayInput.text, MonthInput.text, YearInput.text, NameInput.text, LastnameInput.text, Sexinput));
        });



    }


}
