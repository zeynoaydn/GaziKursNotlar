using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCalisma : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        //Instantiate(target);
        //Instantiate(target.transform);
        //Instantiate(target.transform);
        //Instantiate(target.transform);
        //Instantiate(target.transform);
        //Instantiate(target.transform);
        //Instantiate(target.transform);
        //Instantiate(target,Vector3.zero,Quaternion.identity);
        //Instantiate(target,new Vector3(0,10,0),Quaternion.identity);

        //for(int i = 0; i < 10; i++)
        //{
        //    GameObject go = Instantiate(target);
        //    go.transform.position =new Vector3(i+10,8,0);
        //    go.transform.SetParent(transform);
        //}

        for (int i = 0; i < 10; i++)
        {
            int randomInteger=Random.Range(-20, 20);
            GameObject go = Instantiate(target);
            go.transform.position = new Vector3(randomInteger*i,0,randomInteger);
            go.transform.SetParent(transform);
        }


        //GameObject go1 = Instantiate(target);
        //go1.transform.position =new Vector3(10,0,0);
        //go1.transform.SetParent(transform);


    }
    void Update()
    {
        
    }
}
