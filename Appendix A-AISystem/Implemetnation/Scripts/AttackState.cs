using AISystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State {

    public AttackState(GameObject enemy)
    {
        priorityNum = 9;

        stateName = "Attacking";

        this.enemy = enemy;

        callTextUpdate += GameObject.Find("Canvas").GetComponent<EnemyState>().UpdateText;
    }

    public override void Execute()
    {
        callTextUpdate(this);

        Debug.Log(enemy.name + "is attacking");
    }
}
