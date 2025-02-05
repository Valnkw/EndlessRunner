using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementStrategy : ScriptableObject, IMovementStrategy
{
    //overriding the GetSpeed method from strategy classes to return their specific speed.
    public abstract float GetSpeed();

    public abstract void ApplyAppearance(GameObject target);
    
}
