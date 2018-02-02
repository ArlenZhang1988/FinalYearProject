using System;
using System.Collections.Generic;
using System.Text;

namespace AISystem
{
    public class StateMachine
    {
        State currentState;

        public void ChangeState(State passState)
        {
            currentState = passState;
        }

        void ExecuteState()
        {
            currentState.Execute();
        }
    }
}
