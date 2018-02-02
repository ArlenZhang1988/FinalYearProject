using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerControllerSystem
{
    class StateMachine
    {
        #region singelton
        private static StateMachine instance;

        public static StateMachine Instance()
        {
            if (instance == null)
            {
                instance = new StateMachine();
            }

            return instance;
        }
#endregion

        State currentState;

        Dictionary<StateType, State> stateTypeWithStateDic = new Dictionary<StateType, State>();

        public void SetUp(State state)
        {
            currentState = state;
        }

        public State GetState(StateType stateType)
        {
            return stateTypeWithStateDic[stateType];
        }

        public void AddState(StateType stateType, State newState)
        {
            stateTypeWithStateDic.Add(stateType, newState);
        }

        public void MoveForward()
        {
            currentState.MoveForward();
        }
        public void MoveBackward()
        {
            currentState.MoveBackward();
        }
        public void MoveLeft()
        {
            currentState.MoveLeft();
        }
        public void MoveRight()
        {
            currentState.MoveRight();
        }   

        public void Attack()
        {
            currentState.Attack();
        }

        public virtual void Jump()
        {
        }
    }
}
