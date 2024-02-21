using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MateryalChanges : MonoBehaviour
{
    void Start()
    {
        MeshRenderer meshRenderer =GetComponent<MeshRenderer>();

        Debug.Log(meshRenderer.material.name);

        //Color newColor = Random.ColorHSV();
        //meshRenderer.material.color = newColor;

        Material mat = meshRenderer.material;
        //Material mat2 = meshRenderer.sharedMaterial; //tüm nesnelerin rengini deðiþtiryor
        //mat.color = Color.red;
        //mat.color = new Color(30, 78, 1);
        mat.color = new Color(0.2f, 0.23f, 0.6f);
    }

    void Update()
    {
        
    }
}
