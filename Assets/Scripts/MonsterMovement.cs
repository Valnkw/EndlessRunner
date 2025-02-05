using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    //Varibles
   [SerializeField, Range(1, 20)] private float MoveSpeed = 3.0f;
   [SerializeField, Range(1, 20)] private float ChaseRadius = 10.0f;
   [SerializeField] private Transform Player;

    //Methods
    //Update is called once per frame
    private void Update()
    {
        float DistanceToPlayer = Vector3.Distance(transform.position, Player.position); //Calculate distance to player
        if (DistanceToPlayer <= ChaseRadius)
        {
            //Move towards player
            ChasePlayer();
        }
    }

    private void ChasePlayer()
    {
        Vector3 MoveDirection = (Player.position - transform.position).normalized;
        transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime, Space.World);
    }

   
}
