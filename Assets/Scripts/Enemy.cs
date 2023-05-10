using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public bool playerChasing;

    private Transform playerTransform;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
    }

    private void FixedUpdate()
    {
        if (playerChasing)
        {
            navMeshAgent.destination = playerTransform.position;
        }
    }
}
