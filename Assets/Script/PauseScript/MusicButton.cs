using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    public Text textOfButton;
    public AudioSource musicIntro;
    public AudioSource musicLoop;
    private void Awake()
    {
        if (CheckMusicSwitch.musicIsOn == true)
        {
            musicIntro.volume = 1;
            musicLoop.volume = 1;
            textOfButton.text = "Music on";
        }
        else
        {
            musicIntro.volume = 0;
            musicLoop.volume = 0;
            textOfButton.text = "Music off";
        }
    }
    public void TurnOnOff()
    {
        if (CheckMusicSwitch.musicIsOn == true)
        {
            CheckMusicSwitch.musicIsOn = false;
            musicIntro.volume = 0;
            musicLoop.volume = 0;
            textOfButton.text = "Music off";
        }
        else
        {
            CheckMusicSwitch.musicIsOn = true;
            musicIntro.volume = 1;
            musicLoop.volume = 1;
            textOfButton.text = "Music on";
        }
    }
}
