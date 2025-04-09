using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCamScript : MonoBehaviour
{
    [SerializeField] private CameraSwitchScripts cameras;
    [SerializeField] private Camera switchCam;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCameras()
    {
        foreach (var camera in cameras.GetCameras())
        {
            camera.enabled = false;
        }

        switchCam.enabled = true;
    }
}
