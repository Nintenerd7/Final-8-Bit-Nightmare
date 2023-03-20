using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slider_Logic : MonoBehaviour
{
    //variables used
    private AudioSource AudioSrc;
    public GameObject ObjAudio;
    private float AudioVolume = 1f;

    public UnityEngine.UI.Slider sliders;
    private float value;
    //
    void Start()
    {
        //allows volume value to pass through each scene. 
        ObjAudio = GameObject.FindWithTag("GameAudio");
        AudioSrc = ObjAudio.GetComponent<AudioSource>();
        //

        //automatically sets the value of the volume slider 
        AudioVolume = PlayerPrefs.GetFloat("volume");
        AudioSrc.volume = AudioVolume;
        sliders.value = AudioVolume;
        //
    }

    void Update()
    {
        //sets value
        AudioSrc.volume = AudioVolume;
        PlayerPrefs.SetFloat("volume", AudioVolume);
        //
    }

    public void SetVolume(float volume)
    {
        //allows player to increase or decrease volume
        AudioVolume = volume;
        //

    }


}