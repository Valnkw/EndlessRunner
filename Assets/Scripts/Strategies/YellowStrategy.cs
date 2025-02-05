using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStrategy : IMovementStrategy
{
    public float GetSpeed()
    {
        return 5.0f;
    }
}
