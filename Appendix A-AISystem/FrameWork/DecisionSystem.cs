using System;
using System.Collections.Generic;
using System.Linq;

namespace AISystem
{
    public class DecisionSystem
    {
        List<PerceptionSystem> perceptionSystemList;
        List<State> readyToChangeList;

        StateMachine stateMachine;

        public DecisionSystem()
        {
            perceptionSystemList = new List<PerceptionSystem>();
            readyToChangeList = new List<State>();

            stateMachine = new StateMachine();
        }

        void StartDetect()
        {
            foreach (var temp in perceptionSystemList)
            {
                State returnedState = temp.Detect();

                if (returnedState != null && readyToChangeList.Contains(returnedState) == false)
                {
                    readyToChangeList.Add(returnedState);
                }
            }

            ComparePriority();
        }

        void ComparePriority()
        {
            State passState = readyToChangeList.ElementAt(0);

            foreach (var temp in readyToChangeList)
            {
                if (temp.PriorityNumer> passState.PriorityNumer)
                {
                    passState = temp;
                }
            }

            SendRequest(passState);

            readyToChangeList.Clear();
        }

        void SendRequest(State passState)
        {
             stateMachine.ChangeState(passState);
        }

        public void AddPerceptionSystem(PerceptionSystem perceptionSystem)
        {
            perceptionSystemList.Add(perceptionSystem);
        }

        public void RemovePerceptionSystem(PerceptionSystem perceptionSystem)
        {
            perceptionSystemList.Remove(perceptionSystem);
        }

    }
}

