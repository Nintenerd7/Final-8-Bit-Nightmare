using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused;

    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                resume();
            }
            else
            {
                Paused();
            }
        }
    }
    public void Paused()
    {
        IsPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;//pauses menu
    }


    public void resume()
    {
        IsPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
    }

    public void Menu()
    {
        IsPaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);//loads title screen
        Time.timeScale = 1f;//menu disapears
    }
}