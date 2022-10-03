using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }

  

    

}
