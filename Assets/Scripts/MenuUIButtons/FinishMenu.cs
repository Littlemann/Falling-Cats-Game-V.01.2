using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class FinishMenu : MonoBehaviour
{   
    public int coins;
    [SerializeField] Button playAgain;
    [SerializeField] Button menuButton;
    [SerializeField] Button settings;
    [SerializeField] TextMeshProUGUI textCoins;
    
    void Start()
    { 
        playAgain.onClick.AddListener(TaskOnClickPlay);
        menuButton.onClick.AddListener(TaskOnClickMenu);
        coins = PlayerPrefs.GetInt("Coins"); 
        textCoins.text = coins.ToString();
        

    }

    void TaskOnClickPlay()
    {   
        PlayerPrefs.SetInt("Coins",0);
        SceneManager.LoadScene("Level1");
          
    }
    void TaskOnClickMenu()
    {   
        PlayerPrefs.SetInt("Coins",0);
        SceneManager.LoadScene("Menu");
          
    }

}   

