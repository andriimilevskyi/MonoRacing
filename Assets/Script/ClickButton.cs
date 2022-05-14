using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ClickButton : MonoBehaviour
{
    public int OpenSceneNumb;
    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex + OpenSceneNumb);
        
    }
}
