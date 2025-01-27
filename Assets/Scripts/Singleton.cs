using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public bool isTutorialShown = false;
    
    // private void Awake()
    // {
    //     int numberOfSingletons = FindObjectsOfType<Singleton>().Length;
    //     if (numberOfSingletons > 1)
    //     {
    //         Destroy(gameObject);
    //     }
    //     else
    //     {
    //         DontDestroyOnLoad(gameObject);
    //     }
    // }
    
    public static Singleton Instance { get; private set; }

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
            DontDestroyOnLoad(gameObject);
        } 
    }
}
