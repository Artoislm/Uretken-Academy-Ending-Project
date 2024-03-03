using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Butonlar : MonoBehaviour
{
    public void CikisButonu()
    {
        Application.Quit();
    }
    public void YeniOyun()
    {
        SceneManager.LoadScene("lvl1");
    }
    public void YenidenDene1()
    {
        SceneManager.LoadScene("lvl1");
    }
    
    public void SonrakiLevel()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void YenidenDene2()
    {
        print("çalýþtým");
        SceneManager.LoadScene("lvl2");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }


    public void Anaekran()
    {
        SceneManager.LoadScene("GirisEkrani");
    }

    public void On_Value_Changed (float deger)
    {
        print(deger);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
