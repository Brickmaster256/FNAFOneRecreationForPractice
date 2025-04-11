using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCamsScript : MonoBehaviour
{
    [SerializeField] private GameObject closeCamUI;
    [SerializeField] private GameObject openCamUI;


    public bool open; 
    void Start()
    {
        openCamUI.GetComponent<Canvas>().enabled = false;
        closeCamUI.GetComponent<Canvas>().enabled = true;
        open = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openCamUI.GetComponent<Canvas>().enabled = !openCamUI.GetComponent<Canvas>().enabled;
            closeCamUI.GetComponent<Canvas>().enabled = !closeCamUI.GetComponent<Canvas>().enabled;
            open = !open;

        }
    }
}
