using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScripts : MonoBehaviour
{
    public Camera[] cameraList;

    [SerializeField] private int waitLimit = 100;

    private bool isCycling = false;

    private int waitTime = 0;
    private int cameraIndex;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var camera in cameraList)
        {
            camera.enabled = false;
        }
        cameraList[0].enabled = true;
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
            waitTime++;
            if (waitTime >= waitLimit)
            {
                waitTime = 0;
                CycleThroughCameras();
            }
            
        }
        else
        {
            cameraIndex = 0;
            foreach(var camera in cameraList)
            {
                camera.enabled = false;
            }
            cameraList[0].enabled= true;
        }
    }

    private void CycleThroughCameras()
    {
        cameraIndex += 1;
        if (cameraIndex >= cameraList.Length) 
        {
            
            cameraIndex = 1;
        }

        foreach (var camera in cameraList)
        {
            camera.enabled = false;
        }
        cameraList[cameraIndex].enabled = true;
    }

    public Camera[] GetCameras()
    {
        return cameraList;
    }
    
    public void ClearCameras()
    {
        foreach (var camera in cameraList)
        {
            camera.enabled = false;
        }
    }
    public void SetCamera(Camera currentCam)
    {
        currentCam.enabled = true;
    }
}
