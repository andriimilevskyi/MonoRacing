using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public GameObject Background;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public GameObject PauseButton;

    public void OnClickResumeButton()
    {
        Background.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        PauseButton.SetActive(true);
    }
    private void Update()
    {
            PauseButton.SetActive(false);     
    }
}
