using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BonnieMovement : MonoBehaviour
{
    public Transform[] cameraPositions;
    [SerializeField] private float waitTime = 4.98f;
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
       StartCoroutine(MovementTiming());
    }

    private IEnumerator MovementTiming()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Debug.Log("Switch");
            currentCameraIndex = (currentCameraIndex + 1) % cameraPositions.Length;
            yield return new WaitForSeconds(waitTime);
            agent.SetDestination(cameraPositions[currentCameraIndex].position);
            
        }
    }

}
