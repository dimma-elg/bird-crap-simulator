using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool pauseMenuOpen;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseMenuOpen = !pauseMenuOpen;
            pauseMenu.SetActive(pauseMenuOpen);
        }
            
    }
}
