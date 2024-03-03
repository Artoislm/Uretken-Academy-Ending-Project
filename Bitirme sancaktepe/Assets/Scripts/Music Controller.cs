using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;


public class M : MonoBehaviour
{
    public AudioMixer mixer;

    public GameObject window;
    public Slider musicSlider;

    void SetSliders()
    {

        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    } 

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))

        {
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));

            SetSliders();
        }
        else
        {
            SetSliders();
        }

    }

    public void UpdateMusicVolume()
    {
        mixer.SetFloat("MusicVolume", musicSlider.value);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            window.SetActive(!window.activeInHierarchy);
            if (window.activeInHierarchy)
                Cursor.lockState = CursorLockMode.None;
            else
                Cursor.lockState = CursorLockMode.Locked;

        }
    } 
}







    // Start is called before the first frame update
