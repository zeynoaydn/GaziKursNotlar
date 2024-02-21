using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaziUsuluMath : MonoBehaviour
{
    public Transform kure0;
    public Transform kure1;
    public Transform kure2;
    public Transform kure3;
    [Range(0f, 360f)]
    public float x = 0;
    [Range(0f, 360f)]
    public float y = 0;
    [Range(0f, 360f)]
    public float z = 0;
    void Start()
    {
        
    }
    void Update()
    {
        //kure0.position = new Vector3(3, 4, 5);

        Vector3 deneme = new Vector3(0, 0, 2);
        //Vector3 deneme2 = new Vector3(0,90,0);
        Vector3 deneme2 = new Vector3(x,y,z);
        Quaternion qr =Quaternion.Euler(deneme2);

        kure0.position = qr * deneme;
        kure1.rotation = qr;
        
    }
    public void deneme1234()
    {
        kure0.position = new Vector3(3, 4, 5);

    }
}
