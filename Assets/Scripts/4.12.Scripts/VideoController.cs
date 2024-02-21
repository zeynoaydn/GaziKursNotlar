using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject selamm;
    VideoPlayer player;
    public TMP_Text foto;
    public Image imageee;
    public Sprite PlaySprite;
    public Sprite PauseSprite;

    void Start()
    {
        player = GetComponent<VideoPlayer>();

        player.Pause();
    }

    void Update()
    {
        ////player.playbackSpeed = 5;
        ////player.isLooping = false;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("selam");
        //    player.Play();

        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log("selam yok");

        //    player.Pause();
        //}
        
    }
    //public void Denemememmememe()
    //{
    //    if (!player.isPlaying)
    //    {
    //        player.Play();
    //        buttonText.text = "selam";
    //    }
    //    else
    //    {
    //        player.Pause();
    //        buttonText.text = "naber";

    //    }
    //}
    public void IconDegistir()
    {
        if (!player.isPlaying)
        {
            player.Play();
            imageee.sprite = PauseSprite;
        }
        else
        {
            player.Pause();
            imageee.sprite = PlaySprite;


        }
    }
    public void ViodeDurdur()
    {
        player.Pause();
    }
    public void ViodeDevam()
    {
        player.Play();
    }
}
