using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParetnChildScript : MonoBehaviour
{
    void Start()
    {
        //string isim=transform.GetChild(0).name;
        string isim=gameObject.transform.GetChild(0).gameObject.name;
        Debug.Log(isim);
    }

    void Update()
    {
        
    }
}
