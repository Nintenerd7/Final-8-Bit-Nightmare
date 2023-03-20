using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{

   public void Relive()
    {
        SceneManager.LoadScene(2);
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene(1);
        
    }
}
