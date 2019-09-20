using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue
{
    private List<Turn> turns = new List<Turn>();
    private Queue nextQueue = new Queue();

    public List<Turn> Turns {
        get {
            return turns;
        }

        set {
            turns = value;
        }
    }

    public void AddTurn(Turn turn) {
        turns.Add(turn);
    }

    public Queue Next() {
        turns[0].ProcessTurn();
        turns.RemoveAt(0);
        nextQueue.Turns = turns;
        return nextQueue;
    }
}