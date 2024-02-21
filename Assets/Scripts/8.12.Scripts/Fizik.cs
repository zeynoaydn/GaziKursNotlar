using UnityEngine;

public class Fizik : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Rigidbody body= GetComponent<Rigidbody>();
        Vector3 kuvvetYonu = new Vector3(0, 10.0f, 0);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //IsTrigger kapal� olacak
            //use gravity kapal� olacak
            body.AddForce(kuvvetYonu, ForceMode.Force);

        }
    }

    //Is Trigger kapal�
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision enter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("collision stay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collision exit");
    }
    //Ontrigger � kullanmak i�in Is Trigger a��k olacak
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit");
    }
}
