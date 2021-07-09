using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoSingleton<BackGroundMusic>
{
    AudioSource bgSource;
   [SerializeField] AudioClip failure;
    private void Awake()
    {
        bgSource = GetComponent<AudioSource>();
       
    }
    public void PauseMusic()
    {
        bgSource.mute = true;
    }

    public void ResumeMusic()
    {
        bgSource.mute = false;
    }
   
    

  
}
