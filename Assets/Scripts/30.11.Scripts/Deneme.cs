using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Buras� Start");
        

        //string isim = "";
        //isim=gameObject.name;
        //Debug.Log(isim);

        //gameObject.SetActive(false);

        Transform tr = gameObject.transform;
        //Vector3 position = tr.position;
        //Vector3 position = gameObject.transform.position;
        //Debug.Log(position);

        //Quaternion q = tr.rotation; //rotation
        //Debug.Log(q);

        //kod �al��maz ��nk� start bir kere �al���r ve yakalaman zor olur
        //if(Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("enter a bas�ld�");
        //}
        //else
        //{
        //    Debug.Log("enter a bas�lmad�");
        //}

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Buras� Update");

        //Transform tr = gameObject.transform;
        //Vector3 position = tr.position;
        //Debug.Log(position);

        //Quaternion q = gameObject.transform.rotation; //rotation
        ////Debug.Log(q);
        //Debug.Log(q.eulerAngles); //de�i�imi yaparken anl�k olarak g�rmemizi sa�l�yor

        //Vector3 s = gameObject.transform.localScale; //scale
        //Debug.Log(s); 

        //BoxCollider collider=gameObject.GetComponent<BoxCollider>();
        //collider.enabled = false;

        //MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        //meshRenderer.enabled = false;

        //if (Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("enter a bas�ld�");
        //}
        //else
        //{
        //    Debug.Log("enter a bas�lmad�");
        //}

        //if (Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("getkey");
        //}
        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    //bas�l� tutunca yazar
        //    Debug.Log("getkeydown");
        //}
        //if (Input.GetKeyUp(KeyCode.N))
        //{
        //    Debug.Log("getkeyup");
        //}
        //else
        //{
        //    Debug.Log("olmad�");
        //}

        //if (Input.GetKey(KeyCode.Return))
        //{
        //    MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        //    if (meshRenderer.enabled == false)
        //    {
        //        meshRenderer.enabled = true;
        //    }
        //    else
        //    {
        //        meshRenderer.enabled = false;
        //    }
        //}
        //else
        //{
        //    Debug.Log("a");
        //}

        //Selam();

    }

    public void Selam()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer.enabled == false)
            {
                meshRenderer.enabled = true;
            }
            else
            {
                meshRenderer.enabled = false;
            }
        }
        else
        {
            Debug.Log("a");
        }
    }

    //private void OnApplicationQuit()
    //{
    //    Debug.Log("Quit");
    //}

}
