using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        for (int i = -50; i < 100; i++)
        {
            int randomInteger = Random.Range(-50,50);
            GameObject go = Instantiate(target);
            go.transform.position = new Vector3(randomInteger * i, 0, randomInteger);
            go.transform.SetParent(transform);
        }
    }

    void Update()
    {
        
    }
}
