using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerControllerSystem
{
    enum KeyCodes { W, S, A, D, J, SPACE, K, C };

    enum StateType { IDLE, WALK, CROUCH, WALKBACKWARD }

    delegate void CharacterBehavior();
}
