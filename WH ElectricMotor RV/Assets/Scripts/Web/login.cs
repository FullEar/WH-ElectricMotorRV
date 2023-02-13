using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{

    public InputField UsernameInput;
    public InputField PasswordInput;
    public Button LoginButton;
    // public Button RegisterButton;
    // Start is called before the first frame update
    void Start()
    {
        LoginButton.onClick.AddListener(() =>
        {
            StartCoroutine(MainWeb.Instance.WebRequest.Login(UsernameInput.text, PasswordInput.text));
        });
        /*
        RegisterButton.onClick.AddListener(() =>
        {
            StartCoroutine(MainWeb.Instance.WebRequest.RegisterUser(UsernameInput.text, PasswordInput.text));
        });
        */
    }

    
}
