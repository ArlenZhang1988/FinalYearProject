using AISystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State {

    public Vector3 startPosition;

     public IdleState(GameObject enemy)
    {
        priorityNum = 1;

        stateName = "Idle";

        this.enemy = enemy;

        startPosition = enemy.transform.position;

        callTextUpdate += GameObject.Find("Canvas").GetComponent<EnemyState>().UpdateText;
    }

    public override void Execute()
    {
        callTextUpdate(this);

        Debug.Log(enemy.name + "is idling");
    }
}