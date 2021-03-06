﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;
    public LayerMask whatIsGround, WhatIsPlayer;

//Patrol
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    //Attack

   public float timeBetweenAttacks;
   bool alreadyAttacked;

   //States
   public float sightRange, attackRange;
   public bool playerInSightRange, playerInAttackRange;

   private void Awake()
   {
       player = GameObject.Find("PlayerObj").transform;
       agent = GetComponent<NavMeshAgent>();
   }

   private void Update()
   {
       playerInSightRange = Physics.CheckSphere(transform.position, sightRange, WhatIsPlayer);
       playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, WhatIsPlayer);

       if (!playerInSightRange && !playerInAttackRange) Patrolling();
       if (playerInSightRange && !playerInAttackRange) ChasePlayer();
       if(playerInAttackRange && playerInSightRange) AttackPlayer();  
   }

   private void Patrolling()
   {
if (!walkPointSet) SearchWalkPoint();

if (walkPointSet)
agent.SetDestination(walkPoint);

Vector3 distanceToWalkPoint = transform.position - walkPoint;

if (distanceToWalkPoint.magnitude < 1f)
walkPointSet = false;
   }


private void SearchWalkPoint()
{
    float randomZ = Random.Range(-walkPointRange, walkPointRange);
    float randomX = Random.Range(-walkPointRange, walkPointRange);
} 
   

   private void ChasePlayer()
   {
       agent.SetDestination(player.position);
   }

   private void AttackPlayer()
   {
       agent.SetDestination(transform.position);

       transform.LookAt(player);

   }
}
