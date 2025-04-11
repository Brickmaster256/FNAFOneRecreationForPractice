using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCamScript : MonoBehaviour
{
    [SerializeField] private CameraSwitchScripts cameras;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCameras( Camera newCamera)
    {
        cameras.ClearCameras();
        cameras.SetCamera(newCamera);
    }
}
