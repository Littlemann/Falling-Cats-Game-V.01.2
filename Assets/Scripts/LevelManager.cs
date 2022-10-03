using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
     
     public static LevelManager Instance;
     
    void Awake()
    {
        SingletonPattern();
    }

     void SingletonPattern()
    {
        if (Instance == null) 
        {
        
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else if (Instance != this) 
        {
            Destroy(Instance.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
     
     
    

   

     
  
}
