using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singelton<T> : MonoBehaviour where T : MonoBehaviour   // constarint criteria yemchi 3alaha 
{
    // Start is called before the first frame update
    public static T instance;
    public bool DestroyOnLoad;
    private void Awake()
    {
        RegistreSingelton();
    }
    protected void RegistreSingelton()
    {
        if (instance == null)
        { instance = this as T;// this reflect  singelton but instance reflect T so you should cost  
            if (DestroyOnLoad)
                DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
                }
}
