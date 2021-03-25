using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent enemyMesh;

    private void Start() 
    {
        
    }

    void Update()
    {
        enemyMesh.SetDestination(player.position);
    }





   
}
