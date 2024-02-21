using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    void Start()
    {
        GameObject[] goArray = new GameObject[transform.childCount];
        float nesne = 360/(float)(goArray.Length-1);

        for(int i = 0; i < transform.childCount; i++)
        {
            goArray[i]=transform.GetChild(i).gameObject;
        }

        Vector3 initialPos=new Vector3(-10,0,0);

        for(int i = 0;i < transform.childCount;i++)
        {
            Vector3 angle = new Vector3(0, 0, -1*nesne * i);
            //Vector3 angle = new Vector3(0, 0, -1 * 18 * i);

            Quaternion q = Quaternion.Euler(angle);

            goArray[i].transform.position=q*initialPos;
        }
    }
    void Update()
    {

    }
}
