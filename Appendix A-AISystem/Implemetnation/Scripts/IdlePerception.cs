using AISystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdlePerception : PerceptionSystem
{
    public IdlePerception(State state)
    {
        this.state = state;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override State Detect()
    {
        IdleState state = (IdleState)this.state;

        if (Vector3.Distance(state.enemy.transform.position, state.startPosition) < 3f)
        {
            return state;
        }

        return null;
    }
}