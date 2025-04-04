using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScripts : MonoBehaviour
{
    public Camera mainCam;
    public Camera stageCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam.enabled = true;
        stageCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCam.enabled = !mainCam.enabled;
            stageCam.enabled = !stageCam.enabled;
        }
    }
}
