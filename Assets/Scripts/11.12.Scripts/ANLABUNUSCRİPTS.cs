using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANLABUNUSCRİPTS : MonoBehaviour
{
    public GameObject kup;
    public Transform trans;
    public MeshFilter mesh;
    public GizenNew myGizem;
    public Esra esramm;
    void Start()
    {
        //Debug.Log(kup.name);
        //Vector3 pos1 = kup.transform.position;
        //Vector3 pos2 = trans.position;
        
        //Debug.Log(pos1);
        //Debug.Log(pos2);
        //Debug.Log("selam mesh:"+mesh.name);

        //myGizem.GizeminAdi();
        //Debug.Log(myGizem.yas);
        //Debug.Log(myGizem.yas2 = 34);

        esramm.digerGizem = myGizem;
    }

    void Update()
    {
        
    }
}
