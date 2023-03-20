using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_Not_Destroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] AudioObj = GameObject.FindGameObjectsWithTag("GameAudio");//finds object with tag game audio 
        if (AudioObj.Length > 1)//if there is more than one audio source
        {
            Destroy(this.gameObject);//destroy this game object 
        }//end if
        DontDestroyOnLoad(this.gameObject);//keeps the game object in each scene. 
    }


}