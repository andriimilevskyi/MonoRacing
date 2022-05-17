using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Car : MonoBehaviour
{
    public void OnTriggerEnter(Collider collishion)
    {
        if (collishion.gameObject.name == "Cube")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex + 0);
        }
    }
}
