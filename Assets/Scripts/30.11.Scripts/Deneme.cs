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
        Debug.Log("Burasý Start");
        

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

        //kod çalýþmaz çünkü start bir kere çalýþýr ve yakalaman zor olur
        //if(Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("enter a basýldý");
        //}
        //else
        //{
        //    Debug.Log("enter a basýlmadý");
        //}

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Burasý Update");

        //Transform tr = gameObject.transform;
        //Vector3 position = tr.position;
        //Debug.Log(position);

        //Quaternion q = gameObject.transform.rotation; //rotation
        ////Debug.Log(q);
        //Debug.Log(q.eulerAngles); //deðiþimi yaparken anlýk olarak görmemizi saðlýyor

        //Vector3 s = gameObject.transform.localScale; //scale
        //Debug.Log(s); 

        //BoxCollider collider=gameObject.GetComponent<BoxCollider>();
        //collider.enabled = false;

        //MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        //meshRenderer.enabled = false;

        //if (Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("enter a basýldý");
        //}
        //else
        //{
        //    Debug.Log("enter a basýlmadý");
        //}

        //if (Input.GetKey(KeyCode.Return))
        //{
        //    Debug.Log("getkey");
        //}
        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    //basýlý tutunca yazar
        //    Debug.Log("getkeydown");
        //}
        //if (Input.GetKeyUp(KeyCode.N))
        //{
        //    Debug.Log("getkeyup");
        //}
        //else
        //{
        //    Debug.Log("olmadý");
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
