using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private bool freezeXZAxis = true;

    public float speed;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDirection;
    public Transform orientation;

    private Rigidbody rb;
    
    //jump
    public float playerHeight;
    public LayerMask whatIsGround;
    private bool grounded;

    public float jumpForce;
    public float groundDrag;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * .5f + .2f, whatIsGround);

        if (grounded)
            rb.drag = groundDrag;
        else
        {
            rb.drag = 0;
        }
        if (freezeXZAxis)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
        myInput();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void myInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;//walkin to what u look
        
        rb.AddForce(moveDirection.normalized * speed * 10f);
    }

    void jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    
}
