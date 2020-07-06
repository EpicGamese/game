using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame ()
    {
        SceneManager.LoadScene("Level1");
    }


    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


    public void Controls ()
    {
        SceneManager.LoadScene("Controls");
    }


    public void Back ()
    {
        SceneManager.LoadScene("Home Screen");
    }




    public void Retry ()
    {
        SceneManager.LoadScene("Level1");
    }




    public void NextLevel ()
    {
        SceneManager.LoadScene("Level2");
    }



    public void MainMenuu ()
    {
        SceneManager.LoadScene("Home Screen");
    }


    public void LevelSelect1 ()
    {
        SceneManager.LoadScene("LevelSelect1");
    }


}
