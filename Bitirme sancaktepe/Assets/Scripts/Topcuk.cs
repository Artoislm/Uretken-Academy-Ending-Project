using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Topcuk : MonoBehaviour
{
    private Rigidbody rb;
    public Button Btn;
    public Transform cam;
    public GameObject canvas;
    public float CamDistance = 1.0f;
    public float Hiz = 8.8f;
    public Text zaman, puan, durum;
    float zamanSayaci = 0;
    float puanSayaci = 1000;
    bool oyunDevam = true;
    bool oyunTamam = false;
    
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        canvas.SetActive(false);

    }
    private void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci += Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
            puanSayaci -= Time.deltaTime;
            puan.text = (int)puanSayaci + "";
        }
        else if (!oyunTamam)
        {
            oyunTamam = true;
            durum.text = "Oyun tamamlanamadi";
            Btn.gameObject.SetActive(true);
            //Buralara tekrar 11. videodan bak
        }

        else if(oyunDevam == false)
        {
            durum.text = "You Failed! ";
            canvas.SetActive(true);
        }

        if (zamanSayaci<0)
        {
            oyunDevam = false;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(oyunDevam && !oyunTamam)
        {float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(-yatay * 10, 0, -dikey * 10);
        Vector3 force = kuvvet * Hiz;
        rb.AddForce(force);
        cam.position = rb.position + new Vector3(CamDistance - 3, 4,0);
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        string objName = other.gameObject.name;
        if (objName.Equals("bitis"))
        {
            oyunTamam = true;
            print("GOOOOOOOOOOL!");
            Btn.gameObject.SetActive(true);
            canvas.SetActive(true);
        }

        
              else if (objName.Equals("anakenar") || objName.Equals("labirentduvari"))//burada ayný zamanda puanýn duvara çarpmasý durumunda da düþmesini saðlamaya çalýþtým

        {
            puanSayaci -= 50;
            puan.text = puanSayaci + "";

            if(puanSayaci<=0)
            {
                oyunDevam = false;
            }
        }
    }
}