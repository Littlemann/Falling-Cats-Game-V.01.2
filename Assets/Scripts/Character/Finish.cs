using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Finish : MonoBehaviour
{
    
    
    private int coins;
    

    private void OnEnable()
    {
        GameManager.Instance.OnCollecting += CollectCoins;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnCollecting -= CollectCoins;
    }
   

    private void CollectCoins()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

   private void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag =="Player")
        { 
            
            CompleteLevel();

        }
   }

    public void CompleteLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }  


  }

   


