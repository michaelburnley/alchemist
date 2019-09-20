using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn
{
    private List<Action> actions = new List<Action>();
    private int action_count;
    private bool active;

    public Turn(int numActions) {
        action_count = numActions;
    }

    public List<Action> AddActions(Action action) {
        if (actions.Length <= action_count) {
            actions.Add(action);
        }
        return actions;
    }

    public void ProcessTurn() {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Process();
            Debug.Log("Processing action: " + i);
        }
        Debug.Log("Completed processing actions.");
    }
}