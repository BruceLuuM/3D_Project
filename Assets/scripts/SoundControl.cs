using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{

    public AudioSource src;
    public AudioClip footsteep;

    void footsound()
    {
        src.clip = footsteep;
        src.Play();
    }

}
