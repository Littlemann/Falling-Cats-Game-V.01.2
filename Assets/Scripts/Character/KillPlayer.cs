using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{   
    
    [SerializeField] private GameObject deathParticule;
    
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Trap")
        {
           
            Instantiate (deathParticule, transform.position, transform.rotation);
            this.gameObject.SetActive(false);
            PlayerPrefs.SetInt("TotalCoins",PlayerPrefs.GetInt("Coins") + PlayerPrefs.GetInt("TotalCoins"));
            EndGame();
              
        }
    }

     public void EndGame()
    { 
        SceneManager.LoadScene("FinishScene");
    }

   


 

    


   

}
