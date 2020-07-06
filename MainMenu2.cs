using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public void MainMenu ()
    {
        SceneManager.LoadScene("Home Screen");
    }

    public void Retryyy ()
    {
        
        SceneManager.LoadScene("Level3");
    }

    public void Quit ()
    {
        Application.Quit();
    }

    public void NextLevel ()
    {
        SceneManager.LoadScene("Level4");
    }



}
