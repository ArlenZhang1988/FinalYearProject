using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerControllerSystem
{
    interface ICommand
    {
        void SetUp(CharacterBehavior behavior, KeyCodes keyCode);

        void Execute();
    }
}
