using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScripts : MonoBehaviour
{
    public Camera[] cameraList;
    private bool isCycling = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCycling = !isCycling;
        }
        if (isCycling)
        {
            CycleThroughCameras();
        }
    }

    private void CycleThroughCameras()
    {

    }
    
}
