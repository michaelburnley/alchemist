using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPotion", menuName = "Item/Potion", order = 0)]

public class Potion : Item
{
    [SerializeField]
    private int effect_range;

    [SerializeField]
    private int weight;

    [SerializeField]
    private float duration;

    [SerializeField]
    private PotionType type;

    [SerializeField]
    private EffectType effect;

    [SerializeField]
    private float potency;

    [SerializeField]
    private int wait_time;

    public int EffectRange {
        get {
            return effect_range;
        }
    }
    public int Weight {
        get {
            return weight;
        }
    }
    public float Duration {
        get {
            return duration;
        }
    }
    public PotionType Type {
        get {
            return type;
        }
    }
    public EffectType Effect {
        get {
            return effect;
        }
    }
    public float Potency {
        get {
            return potency;
        }
    }
    public int WaitTime {
        get {
            return wait_time;
        }
    }
}
