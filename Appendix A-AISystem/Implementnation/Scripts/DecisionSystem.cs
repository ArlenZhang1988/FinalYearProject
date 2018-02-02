using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.AI;

namespace AISystem
{
    public class DecisionSystem : MonoBehaviour
    {
        List<PerceptionSystem> perceptionSystemList;
        List<State> readyToChangeList;

        StateMachine stateMachine;

        NavMeshAgent agent;

        public DecisionSystem()
        {
            perceptionSystemList = new List<PerceptionSystem>();
            readyToChangeList = new List<State>();

            stateMachine = new StateMachine();
        }

        public void Start()
        {
            agent = GetComponent<NavMeshAgent>();

            stateMachine.ChangeState(new IdleState(gameObject));
        }

        public void Update()
        {
            StartDetect();

            stateMachine.ExecuteState();
        }

        public void AddPerceptionSystem(PerceptionSystem perceptionSystem)
        {
            perceptionSystemList.Add(perceptionSystem);
        }

        public void RemovePerceptionSystem(PerceptionSystem perceptionSystem)
        {
            perceptionSystemList.Remove(perceptionSystem);
        }

        void ComparePriority()
        {
            if (readyToChangeList.Count == 0)
                return;

            State passState = readyToChangeList.ElementAt(0);

            foreach (var temp in readyToChangeList)
            {
                if (temp == null || passState == null)
                    return;

                if (temp.PriorityNumer > passState.PriorityNumer)
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

        void StartDetect()
        {
            foreach (var temp in perceptionSystemList)
            {
                State returnedState = temp.Detect();

                if (returnedState != null)
                {
                    readyToChangeList.Add(returnedState);
                }
            }

            ComparePriority();
            /*foreach (var temp in perceptionSystemList)
            {
                State returnedState = temp.Detect();

                if (returnedState!=null && ComparePriority(returnedState,stateMachine.CurrentState))
                { 
                    SendRequest(returnedState);

                    //readyToChangeList.Add(returnedState);

                    //ComparePriority();
                }
            }*/
        }
    }
}