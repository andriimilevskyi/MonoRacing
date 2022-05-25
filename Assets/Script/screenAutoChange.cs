using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class screenAutoChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject rotator;
        int x, y;
        x = Screen.width;
        y = Screen.height;
        rotator = GameObject.Find("Background");

        rotator.gameObject.transform.localScale = Vector2(x, y);
    }

    private Vector3 Vector2(int width, int height)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
