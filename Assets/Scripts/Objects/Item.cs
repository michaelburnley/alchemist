using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : ScriptableObject {
    
    [SerializeField]
    protected string name;

    [SerializeField]
    protected Sprite icon;

    [SerializeField]
    protected string description;

    public string Name {
        get {
            return name;
        }
    }

    public Sprite Icon {
        get {
            return icon;
        }

        set {
            icon = value;
        }
    }

    public string Description {
        get {
            return description;
        }
    }
}