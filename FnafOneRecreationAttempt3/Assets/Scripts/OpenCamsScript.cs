using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCamsScript : MonoBehaviour
{
    [SerializeField] private GameObject closeCamUI;
    [SerializeField] private GameObject openCamUI;
    void Start()
    {
        openCamUI.GetComponent<Canvas>().enabled = false;
        closeCamUI.GetComponent<Canvas>().enabled = true;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openCamUI.GetComponent<Canvas>().enabled = !openCamUI.GetComponent<Canvas>().enabled;
            closeCamUI.GetComponent<Canvas>().enabled = !closeCamUI.GetComponent<Canvas>().enabled;
        }
    }
}
