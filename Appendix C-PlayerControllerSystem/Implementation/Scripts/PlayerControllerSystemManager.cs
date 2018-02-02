using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerControllerSystem;

public class PlayerControllerSystemManager : MonoBehaviour {

    [SerializeField]
    Animator playerAnimator;

	// Use this for initialization
	void Start () {
        SetUpCommandManager();
    }

    void SetUpCommandManager()
    {
        CommandManager commandManager = CommandManager.Instance();

        ICommand attack1Command = new Command();
        ICommand attack2Command = new Command();
        ICommand crouchCommand = new Command();
        ICommand jumpCommand = new Command();
        ICommand walkfowardCommand = new Command();
        ICommand walkbackwardCommand = new Command();
        ICommand walkLeftCommand = new Command();
        ICommand walkrightCommand = new Command();

        UnityStateMachine stateMachine = UnityStateMachine.Instance();

        UnityState idleState = new IdleState();
        UnityState walkState = new WalkState();
        UnityState crouchState = new CrouchState();

        idleState.SetUp(stateMachine);
        walkState.SetUp(stateMachine);
        crouchState.SetUp(stateMachine);

        idleState.SetUpInUnity(playerAnimator);
        walkState.SetUpInUnity(playerAnimator);
        crouchState.SetUpInUnity(playerAnimator);

        stateMachine.SetUp(idleState);

        stateMachine.AddState(StateType.IDLE, idleState);
        stateMachine.AddState(StateType.WALK, walkState);
        stateMachine.AddState(StateType.CROUCH, crouchState);

        attack1Command.SetUp(stateMachine.Attack,KeyCodes.J);
        commandManager.AddNewCommand(attack1Command);

        attack2Command.SetUp(stateMachine.Attack2, KeyCodes.K);
        commandManager.AddNewCommand(attack2Command);

        crouchCommand.SetUp(stateMachine.Crouch, KeyCodes.C);
        commandManager.AddNewCommand(crouchCommand);

        jumpCommand.SetUp(stateMachine.Jump, KeyCodes.SPACE);
        commandManager.AddNewCommand(jumpCommand);

        walkfowardCommand.SetUp(stateMachine.MoveForward, KeyCodes.W);
        commandManager.AddNewCommand(walkfowardCommand);

        walkbackwardCommand.SetUp(stateMachine.MoveBackward, KeyCodes.S);
        commandManager.AddNewCommand(walkbackwardCommand);

        walkLeftCommand.SetUp(stateMachine.MoveLeft, KeyCodes.A);
        commandManager.AddNewCommand(walkLeftCommand);

        walkrightCommand.SetUp(stateMachine.MoveRight, KeyCodes.D);
        commandManager.AddNewCommand(walkrightCommand);
    }
}
