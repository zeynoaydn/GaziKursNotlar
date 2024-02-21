using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MpPlayerScript : MonoBehaviour
{
    public AudioSource mAudioSource;
    VideoPlayer mPlayer;

    void Start()
    {
    }
    void Update()
    {
    }
    public void MuzikBaslat()
    {
        mAudioSource.Play();
    }
    public void MuzikDurdur()
    {
        mAudioSource.Stop();
    }
    public void MuzikDenememememmemememe()
    {
        if (!mAudioSource.isPlaying )
        {
            mAudioSource.Play();
            mPlayer.Play();
        }
        else
        {
            mAudioSource.Stop();
            mPlayer.Stop();

        }
    }
}
