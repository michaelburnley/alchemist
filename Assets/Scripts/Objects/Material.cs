using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMaterial", menuName = "Item/Material", order = 0)]

public class Material : Item
{
    [SerializeField]
    private MaterialType type;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private int bundle;

    private MaterialType Type {
        get {
            return type;
        }
    }
    private int Quantity {
        get {
            return quantity;
        }
    }
    private int Bundle {
        get {
            return bundle;
        }
    }
}
