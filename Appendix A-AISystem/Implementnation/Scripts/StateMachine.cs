using System;
using System.Collections.Generic;
using System.Text;

namespace AISystem
{
    public class StateMachine
    {
        private State currentState;

        public State CurrentState { get { if (currentState != null) return null; return currentState;} }

        public bool ChangeState(State passState)
        {
            currentState = passState;

            return true;
        }

        public void ExecuteState()
        {
            currentState.Execute();
        }
    }
}