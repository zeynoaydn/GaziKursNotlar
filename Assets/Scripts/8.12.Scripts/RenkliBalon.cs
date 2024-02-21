using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RenkliBalon : MonoBehaviour
{
    public GameObject Target;
    public GameObject Bullet;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-30, 30), Random.Range(2,15), Random.Range(-30, 30));
            GameObject newObject = Instantiate(Target, randomPosition, Quaternion.identity);
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            Renderer renderer = newObject.GetComponent<Renderer>();
            renderer.material.color = randomColor;
            newObject.transform.SetParent(transform);
        }

        if(Input.GetMouseButtonUp(0))
        {
            GameObject go = Instantiate(Bullet);
            //mermiyi fýrlat bubble ý patlat

        }
    }
    void Update()
    {
        
    }
}
