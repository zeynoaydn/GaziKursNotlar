using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //public List<GameObject> goList=new List<GameObject>();
    void Start()
    {
        GameObject anneObje = new GameObject("Anne");

        //GameObject childObje = new GameObject("�ocuk");
        //childObje.transform.SetParent(anneObje.transform); 

        for(int i = 0; i < 1000; i++)
        {
            GameObject ob = new GameObject("yeni objeler "+i);
            ob.transform.SetParent(anneObje.transform);
            if (i==525)
            {
                ob.name = "isim de�i�tirild";
            }
        }

        anneObje.AddComponent<Rigidbody>();

    }

    void Update()
    {
        
    }
}
