using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestFinishLine : MonoBehaviour
{
    // bool NoOneFinishBefore


    public bool NoOneFinishBefore = true;
    public int WinSceneNum;
    public int LoseSceneNum;

     void OnTriggerEnter(Collider collishion)
    {

        if (collishion.tag == "Bot")
        {
            NoOneFinishBefore = false;
        }
       
       
        if (collishion.tag == "Player")
        {
            if (NoOneFinishBefore == true)
            {
                OpenWinScene();            }
            else
            {
                OpenLoseScene();
            }
        }


void OpenWinScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex + WinSceneNum);
    }
void OpenLoseScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex + LoseSceneNum);
    }
   


}
}
