using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerControllerSystem
{
    abstract class State
    {
        protected StateMachine stateMachine;

        public void SetUp(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public virtual void MoveForward()
        {

        }
        public virtual void MoveBackward()
        {

        }
        public virtual void MoveLeft()
        {

        }
        public virtual void MoveRight()
        {

        }

        public virtual void Attack()
        {

        }

        public virtual void Jump()
        {

        }
    }
}
