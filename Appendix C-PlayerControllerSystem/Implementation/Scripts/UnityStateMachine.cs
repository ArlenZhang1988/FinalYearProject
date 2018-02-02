using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerControllerSystem;
using UnityEngine;

class UnityStateMachine:StateMachine
{
    private static UnityStateMachine instance;

    public new static UnityStateMachine Instance()
    {
        if (instance == null)
        {
            instance = new UnityStateMachine();
        }

        return instance;
    }

    public void Crouch()
    {
        UnityState temp = (UnityState)currentState;

        temp.Crouch();
    }

    public void Attack2()
    {
        UnityState temp = (UnityState)currentState;

        temp.AttackTwo();
    }

    public override void Jump()
    {
        UnityState temp = (UnityState)currentState;

        temp.Jump();
    }
}
