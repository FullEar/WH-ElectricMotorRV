using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWeb : MonoBehaviour
{

    public static MainWeb Instance;
    
    public WebRequest WebRequest;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        WebRequest = GetComponent<WebRequest>();
    }

    
}
