using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveDirection;
    private Rigidbody rb;
    private CharacterController characterController;

    [SerializeField] private float moveSpeed;

    private float inputX;
    private float inputY;

    [SerializeField] private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
        {
            characterController = GetComponent<CharacterController>();
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(inputX, 0, inputY);
        moveDirection.Normalize();

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            Debug.Log("Jumping");
            rb.AddForce(0,2,0);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Floor>())
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
