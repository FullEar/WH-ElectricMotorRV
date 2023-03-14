using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class WebRequest : MonoBehaviour
{

    public GameObject LogginPanel;
    public GameObject GameMenu;
    public GameObject RegisterPanel;
    public GameObject Mainpanel;
    

    void Start()
    {
        LogginPanel.SetActive(true);
        GameMenu.SetActive(false);
        RegisterPanel.SetActive(false);

    }
    //ocultar todo
    public void Panelchange1()
    {
        Mainpanel.SetActive(false);
        
    }
    //Cambio a paner Registro
    public void Panelchange2()
    {
        LogginPanel.SetActive(false);
        GameMenu.SetActive(false);
        RegisterPanel.SetActive(true);
    }
    //Cambio a paner Loggin
    public void Panelchange3()
    {
        LogginPanel.SetActive(true);
        GameMenu.SetActive(false);
        RegisterPanel.SetActive(false);
    }
    //Cambio a panel Game menu sin login
    public void Panelchange4()
    {
        LogginPanel.SetActive(false);
        GameMenu.SetActive(true);
        RegisterPanel.SetActive(false);
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        if (username == "")
        {
            username = "Wrong";
            password = "Credential";
        }
        if (password == "")
        {
            username = "Wrong";
            password = "Credential";
        }
        
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        
        //este metodo es super chaco para verificar el usuario y continuar xd
        string checkuser;

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/WormholeRV/Login.PHP", form))
        {
            yield return www.SendWebRequest();
            
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                
            }
            else
            {
                
                checkuser = (www.downloadHandler.text);
                

                if (checkuser == "Login Succes")
                {
                    LogginPanel.SetActive(false);
                    GameMenu.SetActive(true);
                }


            }
        }
        
    }
    public IEnumerator RegisterUser(string username, string password, string LEmail, string LDay, string LMonth, string LYear, string LName, string LaName, string LSex)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        form.AddField("loginMail", LEmail);
        form.AddField("loginName", LName);
        form.AddField("loginLame", LaName); 
        form.AddField("loginYear", LYear);
        form.AddField("loginMonth", LMonth);
        form.AddField("loginDay", LDay);
        form.AddField("loginSex", LSex);
        




        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/WormholeRV/RegisterUser.PHP", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                
            }
        }
    }

}
