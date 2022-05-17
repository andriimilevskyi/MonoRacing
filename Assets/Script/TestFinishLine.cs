using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestFinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider collishion)
    {

        if (collishion.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + 0);
        }
    }
}
