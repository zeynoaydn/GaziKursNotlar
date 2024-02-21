using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiScript : MonoBehaviour
{
    private float rotationSpeed=1;

    void Start()
    {
        
    }
    void Update()
    {
        Quaternion currentRotation = gameObject.transform.rotation;

        // Yeni bir Quaternion oluþtur, sadece z ekseninde dönme ekleyerek
        Quaternion newRotation = Quaternion.Euler(0, 0, Time.time * rotationSpeed);

        // Yeni rotasyonu uygula
        gameObject.transform.rotation = newRotation;

    }
}
