using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colletcting : MonoBehaviour
{
    
    private int coins = 0;
    [SerializeField] private TextMeshProUGUI textCoins;



    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag =="Coin")
        {
            coins++;
            PlayerPrefs.SetInt("Coins", coins);
            textCoins.text = coins.ToString();
            other.gameObject.SetActive(false);
        }
    }


  
}
