using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongLoopWithIntro : MonoBehaviour
{
    public AudioSource introSource;
    public AudioSource loopSource;

    private void Start()
    {
        // start the intro clip immediately
        introSource.Play();

        // schedule the loop clip to begin as soon as the intro clip ends.
        loopSource.PlayScheduled(AudioSettings.dspTime + introSource.clip.length);
    }
}
