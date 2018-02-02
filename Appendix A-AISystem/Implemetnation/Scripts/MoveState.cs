using AISystem;
using UnityEngine;
using UnityEngine.AI;

public class MoveState : State {

    NavMeshAgent agent;

    GameObject player;

    public MoveState(GameObject enemy)
    {
        priorityNum = 5;

        stateName = "Moving";

        this.enemy = enemy;

        agent = enemy.GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player");

        callTextUpdate += GameObject.Find("Canvas").GetComponent<EnemyState>().UpdateText;
    }

    public override void Execute()
    {
        callTextUpdate(this);

        agent.SetDestination(player.transform.position);

        Debug.Log(enemy.name + "is moving");
    }
}
