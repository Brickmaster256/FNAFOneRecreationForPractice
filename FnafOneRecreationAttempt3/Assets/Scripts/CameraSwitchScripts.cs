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
    public void SetCamera(int currentCam)
    {
        cameraList[currentCam].enabled = true;
        cameraIndex = currentCam;
    }
}
