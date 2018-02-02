using AISystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FleeState : State
{
    public Vector3 startPosition;

    NavMeshAgent agent;

    public FleeState(GameObject enemy)
    {
        priorityNum = 8;

        stateName = "Fleeing";

        this.enemy = enemy;

        startPosition = enemy.transform.position;

        agent = enemy.GetComponent<NavMeshAgent>();

        callTextUpdate += GameObject.Find("Canvas").GetComponent<EnemyState>().UpdateText;
    }

    public override void Execute()
    {
        callTextUpdate(this);

        agent.SetDestination(startPosition);

        Debug.Log(enemy.name + "is fleeing");
    }
}