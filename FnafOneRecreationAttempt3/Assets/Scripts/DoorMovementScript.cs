using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DoorMovementScript : MonoBehaviour
{
    [SerializeField] private Vector3 OpenPosition;
    [SerializeField] private Vector3 ClosePosition;
    private Transform thisTransform;
    public bool isDoorOpen = true;
    void Start()
    {
        isDoorOpen = true;
        UpdatePosition();
    }

 
    

    public void UpdatePosition()
    {
        if(isDoorOpen)
        {
            isDoorOpen=false;
            transform.position = ClosePosition;
        }
        else
        {
            isDoorOpen = true;
            transform.position = OpenPosition;
        }
    }
}
