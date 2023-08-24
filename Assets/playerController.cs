using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public float movementSpeed = 2f; // Adjust this to control movement speed

     public bool isMoving = true;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {    
        if (isMoving)
        {
            MoveForward(); 
        }else StopMove();
        
    }

    void MoveForward()
    {
        // Move the player forward along the X axis based on the movementSpeed
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
    }

    void StopMove()
    {
        isMoving = false;
    }
    
}