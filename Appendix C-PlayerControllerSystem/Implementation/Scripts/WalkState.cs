using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerControllerSystem;
using UnityEngine;

class WalkState : UnityState
    {
    public override void Crouch()
    {
        anim.SetInteger("AnimationType", (int)StateType.CROUCH);

        stateMachine.SetUp(stateMachine.GetState(StateType.CROUCH));

        ControllerDialog.Instance().UpdateDialog("State Changed: Walk to Crouch");
    }

    public override void Attack()
    {
        anim.SetTrigger("Attack1");

        ControllerDialog.Instance().UpdateDialog("Attacking 1 at walk state");
    }

    public override void AttackTwo()
    {
        anim.SetTrigger("Attack2");

        ControllerDialog.Instance().UpdateDialog("Attacking 2 at walk state");
    }

    public override void Jump()
    {
        base.Jump();

        anim.SetTrigger("Jump");

        ControllerDialog.Instance().UpdateDialog("State Changed: Walk to Jump");
    }

    public override void MoveLeft()
    {
        base.MoveLeft();

        anim.gameObject.transform.Rotate(new Vector3(0, -25, 0));
    }

    public override void MoveRight()
    {
        base.MoveRight();

        anim.gameObject.transform.Rotate(new Vector3(0, 25, 0));
    }

    public override void MoveForward()
    {
        anim.SetInteger("AnimationType", (int)StateType.WALK);
    }

    public override void MoveBackward()
    {
        anim.SetInteger("AnimationType", (int)StateType.WALKBACKWARD);

        ControllerDialog.Instance().UpdateDialog("State Changed: Walk to Walk Backward");
    }
}
