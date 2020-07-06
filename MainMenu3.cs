using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu3 : MonoBehaviour
{
    public void Retry ()
    {
        SceneManager.LoadScene("Level4");
    }

    public void NextLevel ()
    {
        SceneManager.LoadScene("Level5");
    }

    public void Quit ()
    {
        Application.Quit();
    }

    public void MainMenuu ()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
