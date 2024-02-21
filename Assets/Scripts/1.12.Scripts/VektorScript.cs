using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VektorScript : MonoBehaviour
{
    public GameObject HedefObje;

    int start = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion q = HedefObje.transform.rotation;
        //Debug.Log(q.eulerAngles);

        //Vector3 euler = q.eulerAngles;
        //q.eulerAngles = new Vector3(25, 20, 15);
        //HedefObje.transform.rotation = q;

        //Vector3 euler = new Vector3(25, 20, 15);
        //HedefObje.transform.rotation = Quaternion.Euler(euler);

        //Vector3 euler = new Vector3(0, start, 0);
        //HedefObje.transform.rotation = Quaternion.Euler(euler);

        //Vector3 angle = new Vector3(0, 1, 0);
        //HedefObje.transform.RotateAround(Vector3.zero, Vector3.up, 1.0f);

        //HedefObje.transform.LookAt(HedefObje2.transform.position);
        //HedefObje.transform.LookAt(Vector3.zero);
        //HedefObje.transform.LookAt(angle);



    }
}

