using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlackStrategy", menuName = "MovementStrategy/Black")]
public class BlackStrategy : MovementStrategy
{

    [SerializeField, Range(1, 50)] private float speed = 1.0f;
    [SerializeField] private Color blackColor = Color.black;
    public override float GetSpeed()
    {
        return speed;
    }

    public override void ApplyAppearance(GameObject target)
    {
        Renderer myRenderer = target.GetComponent<Renderer>();
        if (myRenderer != null)
        {
            myRenderer.material.color = blackColor;
        }
    }
}
