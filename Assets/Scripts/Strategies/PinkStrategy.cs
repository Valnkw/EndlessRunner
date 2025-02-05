using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PinkStrategy", menuName = "MovementStrategy/Pink")]
public class PinkStrategy : MovementStrategy
{

    [SerializeField, Range(1, 40)] private float speed = 5.0f;
    [SerializeField] private Color pinkColor = Color.magenta;
    public override float GetSpeed()
    {
        return speed;
    }

    //Applies color to GameObject depending on the strategy
    public override void ApplyAppearance(GameObject target)
    {
        Renderer myRenderer = target.GetComponent<Renderer>();
        if (myRenderer != null)
        {
            myRenderer.material.color = pinkColor;
        }
    }
}
