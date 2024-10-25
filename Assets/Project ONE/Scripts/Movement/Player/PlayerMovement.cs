using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveDirection;
    public Rigidbody rb;
    private CharacterController characterController;

    [SerializeField] private float moveSpeed;

    [SerializeField] private float inputX;
    [SerializeField] private float inputY;

    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    [SerializeField] float xRotation;
    [SerializeField] float yRotation;

    

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
        {
            characterController = GetComponent<CharacterController>();
            rb = GetComponent<Rigidbody>();
        }

        UnityEngine.Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(inputX, 0, inputY); // introducing move vectors
        moveDirection.Normalize();

        inputX = Input.GetAxisRaw("Horizontal"); // get left right input
        inputY = Input.GetAxisRaw("Vertical"); // get forward back input

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime); // setting movement

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        

    }


}
