using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MahmutunScripti : MonoBehaviour
{
    public GameObject hedefObje;
    [Range(0f, 1f)]
    public float Speed = 0f;
    void Start()
    {
        //MeshFilter filter=hedefObje.GetComponent<MeshFilter>();
        //Debug.Log(filter.mesh.name);

        //BoxCollider boxCollider =hedefObje.GetComponent<BoxCollider>();
        //Debug.Log(boxCollider.center);

        //Vector3 vector3 =hedefObje.transform.position;

        //yeni vekktor tanýmlama
        //Vector3 yeniVector=new Vector3(1f,2f,3f);

        //Debug.Log(vector3);
        //Debug.Log(yeniVector.x);

        //yeniVector.y = 5.0f;
        //yeniVector = new Vector3(4f,3f,6f);
        //hedefObje.transform.position = yeniVector;


    }

    // Update is called once per frame
    public float donmeHizi = 150f;
    void Update()
    {
        //küp böyle ekrandan uzaklakþtý
        Vector3 position = hedefObje.transform.position;
        //position.z += 0.01f;
        //hedefObje.transform.position = position;
        Quaternion rotation = hedefObje.transform.rotation;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            position.x += 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x -= 1f;
        }
        else if (Input.GetKey(KeyCode.I))
        {
            position.y += 1f;
            position.x += 1f;
            position.z += 1f;
        }
        else if (Input.GetKey(KeyCode.H))
        {
            position.z += (1f * Speed);
        }
        hedefObje.transform.position = position;

    }
}
