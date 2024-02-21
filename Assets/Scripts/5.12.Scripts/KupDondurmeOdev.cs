using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupDondurmeOdev : MonoBehaviour
{
    public Transform deneme1;
    public Transform deneme2;

    void Start()
    {
    }

    void Update()
    {
        deneme1.RotateAround(deneme1.position, Vector3.down, 1.0f);
        deneme2.Rotate(Vector3.up*Time.deltaTime*30f);
        //deneme2.RotateAround(3.4f,5f,3.4f);
    }
}
