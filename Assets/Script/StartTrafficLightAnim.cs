using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrafficLightAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>().Play("Traffic light");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
