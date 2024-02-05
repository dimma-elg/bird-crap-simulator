using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
 
    public void CloseGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Damian");
    }
    public void 

    
}
