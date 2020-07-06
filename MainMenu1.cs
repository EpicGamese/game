using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    
    public void MainMenu ()
    {
        SceneManager.LoadScene("Home Screen");
    }

    public void Retryy ()
    {
        
        SceneManager.LoadScene("Level2");
    }

    public void Quit ()
    {
        Application.Quit();
    }


    public void NextLevel ()
    {
        SceneManager.LoadScene("Level3");
    }


}
