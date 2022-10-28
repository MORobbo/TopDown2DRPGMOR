using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;   // Sets a public variable to control the players movespeed 
    private Vector2 moveInput;     // creates a variable Vector 2 which is used for 2D Games and stores it in moveInput
    private Rigidbody2D rb;   // Gives reference to the players RigidBody 2d component and stores it in rb
    Animator animator; 

    private void Start()                        // Upon start up of the game it will ..
    {
        rb = GetComponent<Rigidbody2D>();       // The program is giving reference to the rigidbody component and recieving its information
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()                          // Will check for this a certain amount of times every second regardless of framerate 
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime); // moves the rigidbody component based upon input from the user and movespeed variable 

        
        {
           
        }
        
             }


                                                                                       // time.fixeddeltatime ensures that movement speed is the same regardless of frame rate


    void OnMove(InputValue value)                       //when a move button is pressed it will recieve the input value 
    {
        moveInput = value.Get<Vector2>();               //stores the input value and defines it as a Vector2
    }
}


