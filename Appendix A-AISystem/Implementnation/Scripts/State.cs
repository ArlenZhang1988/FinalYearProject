using UnityEngine;

namespace AISystem
{
    public abstract class State
    {
        public delegate void CallText(State state);

        protected CallText callTextUpdate;

        protected string stateName;

        public string StateName { get { return stateName; } }

        protected int priorityNum;

        public int PriorityNumer { get { return priorityNum; } }

        public GameObject enemy;

        public abstract void Execute();
    }
}