using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void Level0()
    {
        SceneManager.LoadScene("Level0");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    { 
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("CompletedMainMenu");
    }
}
