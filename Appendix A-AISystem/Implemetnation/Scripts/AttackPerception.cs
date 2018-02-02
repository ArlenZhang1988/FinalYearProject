using AISystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerception : PerceptionSystem
{
    public void Update()
    {
        Detect();
    }

    public AttackPerception(State state)
    {
        this.state = state;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override State Detect()
    {
        if (Vector3.Distance(state.enemy.transform.position, player.transform.position) < 2f)
        {
            return state;
        }

        return null;
    }
}