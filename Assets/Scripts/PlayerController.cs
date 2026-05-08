using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 moveInput;
    void Start()
    {
        
    }

    void Update()
    {
        rb2d.linearVelocity = new Vector2(moveInput.x * 5, rb2d.linearVelocity.y);
        rb2d.linearVelocity = new Vector2(rb2d.linearVelocity.x, moveInput.y * 5);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
