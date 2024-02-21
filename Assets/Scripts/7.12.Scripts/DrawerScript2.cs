using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript2 : MonoBehaviour
{
    public int KupCount = 0;
    void Start()
    {
        GameObject[] goArray = new GameObject[KupCount];

        float nesne = 360 / (float)(goArray.Length - 1);

        Vector3 initialPos = new Vector3(-10, 0, 0);

        for (int i = 0; i < KupCount; i++)
        {
            GameObject go=GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.SetParent(transform);
            //bu þekilde uzun oluyor
            //Transform parent = transform; 
            //go.transform.SetParent(parent);

            goArray[i] = go;

            Vector3 angle = new Vector3(0, 0, -1 * nesne * i);
            Quaternion q = Quaternion.Euler(angle);

            goArray[i].transform.position = q * initialPos;
        }
    }
    void Update()
    {
        
    }
}
