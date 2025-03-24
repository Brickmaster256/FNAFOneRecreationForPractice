using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BonnieMovement : MonoBehaviour
{
    public Transform[] cameraPositions;
    [SerializeField] private int waitTime = 5000;
    [SerializeField] private int aIValue = 10;

    [SerializeField] private DoorMovementScript Door;

    private int timeWaited = 0;
    private int currentCameraIndex;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (cameraPositions.Length > 0 )
        {
            agent.SetDestination(cameraPositions[0].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            timeWaited++;
            
            
        }
        else 
        {
            MoveCharacter();
        }

        if (timeWaited >= waitTime)
        {
            timeWaited = 0;
            int moveChance = Random.Range(0, 20);
            if (aIValue >= moveChance)
            {
                
                MoveCharacter();
                Debug.Log("Time to Move");
            }
            Debug.Log(moveChance);
            
        }


    }

   private void MoveCharacter()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            

            currentCameraIndex = (currentCameraIndex + 1) % cameraPositions.Length;

            if (currentCameraIndex == cameraPositions.Length - 1)
            {
                if (!Door.GetIsDoorOpen())
                {
                    currentCameraIndex = cameraPositions.Length - 5;
                }

            }

            agent.SetDestination(cameraPositions[currentCameraIndex].position);
            Debug.Log(cameraPositions[currentCameraIndex].position);


        }
    }

    

}
