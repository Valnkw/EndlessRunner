using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   

    [SerializeField,Range(1,20)] private float MoveSpeed;
    [SerializeField,Range(1,20)] private float JumpForce = 5f;
    [SerializeField] private Rigidbody rb;
    private IMovementStrategy movementStrategy;

    private void Start()
    {
        //Start with default movement strategy
        movementStrategy = new RedStrategy();
    }


    //On Enable
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; //Keep the player from rotating and tipping over
    }
    public void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");
        float Speed = movementStrategy.GetSpeed();

        //Create basic movement
        Vector3 Move = new Vector3(MoveX, 0.0f, MoveZ) * Speed * Time.deltaTime;
        transform.Translate(Move, Space.World);

        //Allows player to jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }

    public void ChangeMovementStrategy(IMovementStrategy newStrategy)
    {
        this.movementStrategy = newStrategy;
    }
}
