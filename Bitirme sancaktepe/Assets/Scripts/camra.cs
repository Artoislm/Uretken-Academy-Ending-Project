using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform cam;
    public Transform top;
    public float CamDistance = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.position = top.position + new Vector3(CamDistance, 5, 0);

    }
}
