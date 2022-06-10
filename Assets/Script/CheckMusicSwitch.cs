using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMusicSwitch : MonoBehaviour
{
    public static bool musicIsOn = true;
    public AudioSource music;
    void Update()
    {
        if (musicIsOn == true)
        {
            music.volume = 1;
        }
        else
        {
            music.volume = 0;
        }

    }
}
