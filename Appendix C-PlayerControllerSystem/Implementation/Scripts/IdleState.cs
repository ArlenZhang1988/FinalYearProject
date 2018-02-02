using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerControllerSystem;
using UnityEngine;

namespace PlayerControllerSystem
{
    class IdleState : UnityState
    {
        float timmer;

        public override void Attack()
        {
            anim.SetTrigger("Attack1");

            ControllerDialog.Instance().UpdateDialog("Attacking 1 at idle state");
        }

        public override void AttackTwo()
        {
            anim.SetTrigger("Attack2");

            ControllerDialog.Instance().UpdateDialog("Attacking 2 at idle state");
        }

        public override void Jump()
        {
            base.Jump();

            anim.SetTrigger("Jump");

            ControllerDialog.Instance().UpdateDialog("Jumping at idle state");
        }

        public override void Crouch()
        {
            anim.SetInteger("AnimationType", (int)StateType.CROUCH);

            stateMachine.SetUp(stateMachine.GetState(StateType.CROUCH));

            ControllerDialog.Instance().UpdateDialog("State Changed: Idle to Crouch");
        }

        public override void MoveLeft()
        {
            base.MoveLeft();

            anim.gameObject.transform.Rotate(0, -25, 0);

            ControllerDialog.Instance().UpdateDialog("Turned Left");
        }

        public override void MoveRight()
        {
            base.MoveRight();

            anim.gameObject.transform.Rotate(0, 25, 0);

            ControllerDialog.Instance().UpdateDialog("Turned Right");
        }

        public override void MoveForward()
        {
            anim.SetInteger("AnimationType", (int)StateType.WALK);

            stateMachine.SetUp(stateMachine.GetState(StateType.WALK));

            ControllerDialog.Instance().UpdateDialog("State Changed: Idle to Walk");
        }

        public override void MoveBackward()
        {
            anim.SetInteger("AnimationType", (int)StateType.WALKBACKWARD);

            stateMachine.SetUp(stateMachine.GetState(StateType.WALK));

            ControllerDialog.Instance().UpdateDialog("State Changed: Idle to Walk Backward");
        }
    }
}