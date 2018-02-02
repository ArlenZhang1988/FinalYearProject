using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerControllerSystem;
using UnityEngine;

abstract class UnityState : State
{
    protected Animator anim;

    public void SetUpInUnity(Animator anim)
    {
        this.anim = anim;
    }

    public abstract void AttackTwo();

    public abstract void Crouch();

    public override void MoveLeft()
    {
        base.MoveLeft();

        ControllerDialog.Instance().UpdateDialog("Turned Left");
    }

    public override void MoveRight()
    {
        base.MoveRight();

        ControllerDialog.Instance().UpdateDialog("Turned Right");
    }
}
