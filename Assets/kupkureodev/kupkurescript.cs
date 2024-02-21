using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupkurescript : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    public float rotationSpeed = 5f;
    public float distanceFromSphere = 2f; // Küpün küreden uzaklýðý

    void Start()
    {
    }

    void Update()
    {
        RotateCubeAroundSphere();
    }
    void RotateCubeAroundSphere()
    {
        float angle = Time.time * rotationSpeed;
        float radius = sphere.localScale.x * 0.5f; 
        float yPos = sphere.position.y + distanceFromSphere;

        float xPos = Mathf.Cos(angle) * radius;
        float zPos = Mathf.Sin(angle) * radius;


        cube.position = new Vector3(xPos, yPos, zPos) + sphere.position;

        if (xPos > 0)
        {
            cube.position = new Vector3(0, yPos, zPos) + sphere.position;
        }
    }
}
