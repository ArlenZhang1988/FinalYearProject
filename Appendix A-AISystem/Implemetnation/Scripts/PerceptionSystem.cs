using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AISystem
{
    public abstract class PerceptionSystem
    {
        public GameObject player;
        
        public State state;

        public abstract State Detect();
    }
}