using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStrategy : IMovementStrategy
{
    public float GetSpeed()
    {
        return 10.0f;
    }
}
