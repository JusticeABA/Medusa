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
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
