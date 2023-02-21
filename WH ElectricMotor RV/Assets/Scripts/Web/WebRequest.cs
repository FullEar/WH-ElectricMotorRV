using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class WebRequest : MonoBehaviour
{
    void Start()
    {
        

    }
    
    
    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
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
                    SceneManager.LoadScene("EmptyTest");
                }


            }
        }
        
    }
    public IEnumerator RegisterUser(string username, string password, string LEmail, string LDay, string LMonth, string LYear, string LName, string LaName, int LSex)
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
