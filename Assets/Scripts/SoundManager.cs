using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    void Start()
    {
        // float flValue;
        // audioMixer.GetFloat("MusicVol", out flValue);
        // flValue = Mathf.Log10(flValue) * 20;
        // Slider slider =  GameObject.Find("Slider").GetComponent<Slider>();
        // slider.value = flValue;

    }

    

    public void setAudio(float sliderValue)
    {
        audioMixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
