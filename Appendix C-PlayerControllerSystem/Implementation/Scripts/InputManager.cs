using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerControllerSystem;

public class InputManager : MonoBehaviour {

    CommandManager commandManager;

    bool canGet= true;

    public void Awake()
    {
        commandManager = CommandManager.Instance();
    }

     public void Update() {
        if (!canGet)
        {
            return;
        }

        if (Input.GetKey(KeyCode.J))
        {
            commandManager.ExecuteCommand(KeyCodes.J);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.K))
        {
            commandManager.ExecuteCommand(KeyCodes.K);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            commandManager.ExecuteCommand(KeyCodes.SPACE);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            commandManager.ExecuteCommand(KeyCodes.C);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            commandManager.ExecuteCommand(KeyCodes.W);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            commandManager.ExecuteCommand(KeyCodes.S);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            commandManager.ExecuteCommand(KeyCodes.A);

            StartCountDown();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            commandManager.ExecuteCommand(KeyCodes.D);

            StartCountDown();
        }
    }

    IEnumerator GetInputCount()
    {
        yield return new WaitForSeconds(1);

        canGet = true;
    }

    private void StartCountDown()
    {
        canGet = false;
        StartCoroutine(GetInputCount());
    }
}
