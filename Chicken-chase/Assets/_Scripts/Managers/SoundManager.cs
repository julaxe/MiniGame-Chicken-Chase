using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    private  AudioSource audioSrc;

    private  AudioClip jump, duck, getHit;
    
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        jump = Resources.Load<AudioClip>("Sounds/RoosterClucks");
        duck = Resources.Load<AudioClip>("Sounds/RoosterChook");
        getHit = Resources.Load<AudioClip>("Sounds/ChickenClucking");

    }
    public void PlaySFX(string key)
    {
        switch (key)
        {
            case "jump":
                audioSrc.PlayOneShot(jump);
                break;
            case "duck":
                audioSrc.PlayOneShot(duck);
                break;
            case "getHit":
                audioSrc.PlayOneShot(getHit);
                break;
            default:
                break;
        }
    }
}
