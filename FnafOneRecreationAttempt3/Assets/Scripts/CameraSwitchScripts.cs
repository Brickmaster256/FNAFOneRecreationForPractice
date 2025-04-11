using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScripts : MonoBehaviour
{
    public Camera[] cameraList;

    
    [SerializeField] private OpenCamsScript camUI;

    

    
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
        if (camUI.open == false)
        {
            SetCamera(0);
        }
        else
        {
            SetCamera(cameraIndex); 
        }
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
        ClearCameras();
        cameraList[currentCam].enabled = true;
        
        if (currentCam != 0)
        {
            cameraIndex = currentCam;
        }
    }
}
