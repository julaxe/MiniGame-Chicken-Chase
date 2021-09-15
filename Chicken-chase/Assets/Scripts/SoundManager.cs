using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    private  AudioSource audioSrc;

    private  AudioClip jump, duck, getHit;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        jump = Resources.Load<AudioClip>("Sounds/RoosterWingFlapping");
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
