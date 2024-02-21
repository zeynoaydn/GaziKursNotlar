using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeOlusturma : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    void Start()
    {
        Debug.Log(gameObject.name);
        AudioSource source=gameObject.AddComponent<AudioSource>();
        //enabled = false; //Scriptin tikini kaldýrýyor
        gameObject1.name = "Zeynepppp";
        gameObject2.name = "Zeynep Nezaket";

        GameObject go=GameObject.Find("GameObject (2)");
        go.name = "deðiþtirildi";

        GameObject yeniObje = new GameObject();
        GameObject yeniObje2 = new GameObject("yeni obje");

        for(int i = 0; i < 1000; i++)
        {
            GameObject yeniObje3 = new GameObject("yeni obje"+i);

        }
    }

    void Update()
    {
        
    }
}
