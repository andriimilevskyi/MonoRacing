using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private Canvas CanvasPause;
    public GameObject Background; 
    public GameObject Button1;
    public GameObject Button2;

    private void Start()
    {
        Background.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
    }
    public void onResumeButtonClick()
    {
        //if (CanvasPause.enabled == true)
        //{
        //    CanvasPause.GetComponent<Canvas>().enabled = false;
        //}
        //else
        //{
        //    CanvasPause.GetComponent<Canvas>().enabled = true;
        //}
        Background.SetActive(true);
        Button1.SetActive(true);
        Button2.SetActive(true);



    }
}
