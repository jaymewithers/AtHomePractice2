using UnityEngine;
using UnityEngine.Events;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 10f;
    private int jumpCount = 0;
    public IntData jumpCountMax;
    public UnityEvent jumpEvent;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        
        positionDirection.x = Input.GetAxis("Horizontal") * speed;

        if (Input.GetButtonDown("Jump") && jumpCount <= jumpCountMax.value)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            jumpCount++;
        }

        positionDirection.y -= gravity;
        controller.Move(positionDirection * Time.deltaTime);
    }
}