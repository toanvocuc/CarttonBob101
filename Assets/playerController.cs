using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public Animator PlayerAnim;
    public float movementSpeed = 2f; // Adjust this to control movement speed
    private bool isMoving = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (isMoving)
        {
            MoveForward();
            PlayerAnim.Play("PlayerWalk");
        }
    }

    private void MoveForward()
    {
        // Move the player forward along the X axis based on the movementSpeed
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void StopMoving()
    {
        isMoving = false;
        PlayerAnim.Play("Idle");
    }
}