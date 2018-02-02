using System;
using System.Collections.Generic;
using System.Text;

namespace AISystem
{
    public abstract class PerceptionSystem
    {
        State state;

        public PerceptionSystem(State state)
        {
            this.state = state;
        }

        public virtual State Detect();
    }
}