using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StopPlay()
    {
        SceneManager.LoadScene("Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
