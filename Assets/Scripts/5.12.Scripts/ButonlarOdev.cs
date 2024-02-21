using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButonlarOdev : MonoBehaviour
{
    public GameObject mygame;
    public Button mybutton;
    public TMP_InputField myinput;
    public TMP_Text mytext;
    void Start()
    {
       
        //mytext.text = myinput.text;
    }
    void Update()
    {

    }
    public void denemefonksiyon(string degisken)
    {
        mytext.text = myinput.text;
        string yazi;
        yazi = mytext.text;
        Debug.Log(yazi);
    }
    public void denemefonksiyonSilme()
    {
        mytext.text = string.Empty;
    }
}
