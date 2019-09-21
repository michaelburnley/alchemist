using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action
{
    private ActionType action_type;
    private string payload;

    public ActionType Action_Type {
        get {
            return action_type;
        }

        set {
            action_type = value;
        }
    }

    public string Payload {
        get {
            return payload;
        }

        set {
            payload = value;
        }
    }

    public bool Validate(string payloadToTest) {
        bool valid = false;
        switch (action_type)
        {
            case ActionType.USE_ITEM:
                valid = UseItemValidate(payloadToTest);
                break;
            case ActionType.MOVE_SELF:
                valid = MoveValidate(payloadToTest);
                break;
            case ActionType.MOVE_OTHER:
                valid = MoveValidate(payloadToTest);
                break;
            case ActionType.ATTACK:
                valid = AttackValidate(payloadToTest);
                break;
            case ActionType.END_TURN:
                valid = true;
                break;
        }

        return validated;
    }

    private bool UseItemValidate() {
        return true;
    }

    private bool MoveValidate() {
        return true;
    }

    private bool AttackValidate() {
        return true;
    }
}
