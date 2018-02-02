using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AISystem;

public class EnemyState : MonoBehaviour {

    Text text;

    public void Start()
    {
        InitNode(this.transform);
    }

    void InitNode(Transform trans)
    {
        if (trans.name == "EnemyStateText")
        {
            text = trans.GetComponent<Text>();
        }

        if (trans.name == "ExitButton")
        {
            trans.GetComponent<Button>().onClick.AddListener(() => { Application.Quit(); });
            
        }

        for (int i = 0; i < trans.childCount; i++)
        {
            InitNode(trans.GetChild(i));
        }
    }

    public void UpdateText(State state)
    {
        text.text = "Enemy State: "+state.StateName;
    }
}
