using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AISystem;

public class EnemyManager : MonoBehaviour {

    DecisionSystem decisionSystem;

    public void Start()
    {
        decisionSystem = gameObject.GetComponent<DecisionSystem>();

        decisionSystem.AddPerceptionSystem(new IdlePerception(new IdleState(this.gameObject)));
        decisionSystem.AddPerceptionSystem(new MovePerception(new MoveState(this.gameObject)));
        decisionSystem.AddPerceptionSystem(new AttackPerception(new AttackState(this.gameObject)));
        decisionSystem.AddPerceptionSystem(new FleePerception(new FleeState(this.gameObject)));
    }
}