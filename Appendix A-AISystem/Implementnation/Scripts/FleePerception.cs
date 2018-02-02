using AISystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleePerception : PerceptionSystem
{
    public FleePerception(State state)
    {
        this.state = state;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override State Detect()
    {
        FleeState state = (FleeState)this.state;

        if (Vector3.Distance(state.enemy.transform.position, state.startPosition) > 10f)
        {
            return state;
        }

        return null;
    }
}
