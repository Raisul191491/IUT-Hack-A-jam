using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    
    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        transform.LookAt(player);
        agent.SetDestination(player.position);
    }
}
