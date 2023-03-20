using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Play()
    {
        //play button 
        SceneManager.LoadScene(4);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
