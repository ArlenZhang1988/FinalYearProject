using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerControllerSystem
{
    class Command : ICommand
    {
        CharacterBehavior behavior;

        KeyCodes key;

        public KeyCodes Key { get { return key; } }

        public virtual void SetUp(CharacterBehavior behavior, KeyCodes keyCode)
        {
            this.behavior = behavior;

            this.key = keyCode;
        }

        public void Execute()
        {
            behavior();
        }
    }
}
