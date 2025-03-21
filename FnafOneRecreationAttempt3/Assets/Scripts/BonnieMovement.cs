using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BonnieMovement : MonoBehaviour
{
    public Transform[] cameraPositions;
    [SerializeField] private int waitTime = 5000;
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
            Debug.Log(timeWaited);
            
        }
        else 
        {
            MoveCharacter();
        }

        if (timeWaited >= waitTime)
        {
            timeWaited = 0;
            MoveCharacter();
            Debug.Log("Time to Move");
        }


    }

   private void MoveCharacter()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            for (int time = 0; time < waitTime; time++)
            {
                Debug.Log("Bonnie Waiting");
            }

            currentCameraIndex = (currentCameraIndex + 1) % cameraPositions.Length;

            agent.SetDestination(cameraPositions[currentCameraIndex].position);
            Debug.Log(cameraPositions[currentCameraIndex].position);


        }
    }

    

}
