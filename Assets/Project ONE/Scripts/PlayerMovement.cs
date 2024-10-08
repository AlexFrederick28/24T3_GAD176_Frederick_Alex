using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveDirection;
    public Rigidbody rb;
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
        inputX = Input.GetAxisRaw("Horizontal"); // get left right input
        inputY = Input.GetAxisRaw("Vertical"); // get forward back input

        moveDirection = new Vector3(inputX, 0, inputY); // introducing move vectors
        moveDirection.Normalize();

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime); // setting movement

        transform.LookAt(Input.mousePosition);
    }

    public void OnCollisionEnter(Collision collision)
    {

        

        if (collision.transform.GetComponent<Floor>())
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
