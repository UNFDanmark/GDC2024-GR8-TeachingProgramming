using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody rb;
    public float speed = 0.1f;
    private NavMeshAgent agent;
    void Awake()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        /*
        Vector3 movementVector = Vector3.MoveTowards(transform.position, playerTransform.position, speed);
        rb.Move(movementVector,quaternion.identity);
        */
        agent.destination = playerTransform.position;
    }
}
