using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterMovement : MonoBehaviour
{

    CharacterController controller;
    public float speed = 5;
    Transform cam;
    float gravity = 10;
    float verticalVelocity = 0; // Changed from 10 to 0 for initial state
    public float jumpValue = 10;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool isSprint = Input.GetKey(KeyCode.LeftShift);
        float sprint = isSprint ? 1.7F : 1;

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");
        }


        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        anim.SetFloat("Speed", Mathf.Clamp(moveDirection.magnitude, 0, 0.5f) + (isSprint ? 0.5f : 0f));


        // Apply gravity continuously
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime; // Keep the character grounded



            if (Input.GetAxis("Jump") > 0)
            {
                verticalVelocity = jumpValue;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // Normalize moveDirection to prevent faster diagonal movement
        if (moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            float angle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }

        moveDirection = cam.TransformDirection(moveDirection);
        moveDirection = new Vector3(moveDirection.x * speed * sprint, verticalVelocity, moveDirection.z * speed * sprint);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
