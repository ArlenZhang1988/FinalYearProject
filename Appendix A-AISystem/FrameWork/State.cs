using System;
using System.Collections.Generic;
using System.Text;

namespace AISystem
{
    public abstract class State
    {
        private int priorityNum;

        public int PriorityNumer { get { return priorityNum; } }

        public abstract void Execute();
    }
}