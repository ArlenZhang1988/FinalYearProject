using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerControllerSystem;
using UnityEngine;

class CrouchState : UnityState
    {
        public override void AttackTwo()
        {
        anim.SetTrigger("CrouchAttack2");

        ControllerDialog.Instance().UpdateDialog("Attacking 2 at crouch state");
    }

    public override void Attack()
    {
        anim.SetTrigger("CrouchAttack1");

        ControllerDialog.Instance().UpdateDialog("Attacking 1 at crouch state");
    }

    public override void Crouch()
    {
        anim.SetInteger("AnimationType", (int)StateType.IDLE);

        stateMachine.SetUp(stateMachine.GetState(StateType.IDLE));


        ControllerDialog.Instance().UpdateDialog("State Changed: Crouch to Idle");
    }

    public override void Jump()
    {
        base.Jump();

        anim.SetTrigger("Jump");

        ControllerDialog.Instance().UpdateDialog("State Changed: Crouch to Jump");
    }

    public override void MoveLeft()
    {
        base.MoveLeft();

        anim.gameObject.transform.Rotate(new Vector3(0, -25, 0));
    }

    public override void MoveRight()
    {
        base.MoveRight();

        anim.gameObject.transform.Rotate(new Vector3(0, 30, 0));
    }

    public override void MoveForward()
    {
        anim.SetInteger("AnimationType", (int)StateType.WALK);

        stateMachine.SetUp(stateMachine.GetState(StateType.WALK));

        ControllerDialog.Instance().UpdateDialog("State Changed: Crouch to Walk");
    }

    public override void MoveBackward()
    {
        anim.SetInteger("AnimationType", (int)StateType.WALKBACKWARD);

        stateMachine.SetUp(stateMachine.GetState(StateType.WALK));

        ControllerDialog.Instance().UpdateDialog("State Changed: Crouch to Walk Backward");
    }
}
