using AISystem;
using UnityEngine;

public class MovePerception : PerceptionSystem {

    public MovePerception(State state)
    {
        this.state = state;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override State Detect()
    {
        if (Vector3.Distance(state.enemy.transform.position,player.transform.position) < 5f)
        {
            return state;
        }

        return null;
    }
}
