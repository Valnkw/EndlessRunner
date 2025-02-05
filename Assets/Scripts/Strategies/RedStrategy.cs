using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStrategy : IMovementStrategy
{
    public float GetSpeed()
    {
        return 1.0f;
    }
}
