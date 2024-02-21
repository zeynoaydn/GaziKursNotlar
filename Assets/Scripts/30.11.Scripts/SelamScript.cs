using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelamScript : MonoBehaviour
{
    //public int TamSayi = 0;
    //public float Ondalik = 0f;
    //public string Selamm = "ZeyZey";
    //public bool Mudo;
    //public char Karakter;
    //public int[] MyArray;
    //[HideInInspector]
    //public List<int> MyList=new List<int>();

    public GameObject DigerObje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Deneme deneme = gameObject.GetComponent<Deneme>();
        //deneme.Selam();

        //Debug.Log(TamSayi);

        Deneme deneme = DigerObje.GetComponent<Deneme>();
        

    }
}
