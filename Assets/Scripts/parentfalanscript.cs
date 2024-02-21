using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class parentfalanscript : MonoBehaviour
{
    Transform mytransform;
    public GameObject cubetransform;
    public GameObject spheretransform;
    void Start()
    {
        mytransform = transform;
        mytransform.GetChild(0).name = "Zeyzey";

        mytransform.name = "Parent";


        //GameObject newChild = new GameObject("child");
        //newChild.transform.parent = mytransform;

        for(int i = 0;i<100;i++)
        {
            GameObject mygame=GameObject.CreatePrimitive(PrimitiveType.Cube);
            mygame.name = "child " + i;
            mygame.transform.parent = mytransform;
        }
    }

    
    void Update()
    {
        
    }
}
