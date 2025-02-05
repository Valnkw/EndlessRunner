using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    private float RotationSpeed = 100f;
    //Allows use of any class that inherits from MovementStrategies
    [SerializeField] private MovementStrategy newStrategy;

    private void Start()
    {
        //Applies the new strategy color to the powerup
        newStrategy.ApplyAppearance(gameObject);
    }
    void Update()
    {
        if (newStrategy != null)
        {
            float speed = newStrategy.GetSpeed();
            transform.Rotate(0.0f, 0.0f, RotationSpeed);
        }
    }

    //Destroy Method from class
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        //Destroy this game object if the colliding object is tagged with player
    //        Destroy(gameObject);
    //    }
    //}

    //My Collision Method
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Movement playerMovement = other.gameObject.GetComponent<Movement>();
            if (playerMovement != null)
            { 
               //old playerMovement.ChangeMovementStrategy(new PinkStrategy());
                playerMovement.ChangeMovementStrategy(newStrategy);
            }
            Destroy(gameObject);
        }
    }
}

