using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlueStrategy", menuName = "MovementStrategy/Blue")]
public class BlueStrategy : MovementStrategy
{

    [SerializeField, Range(1, 50)] private float speed = 1.0f;
    [SerializeField] private Color blueColor = Color.blue;
    public override float GetSpeed()
    {
        return speed;
    }

    public override void ApplyAppearance(GameObject target)
    {
        Renderer myRenderer = target.GetComponent<Renderer>();
        if (myRenderer != null)
        {
            myRenderer.material.color = blueColor;
        }
    }
}
