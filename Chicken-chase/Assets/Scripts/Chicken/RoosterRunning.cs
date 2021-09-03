using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RoosterRunning : MonoBehaviour
{
    private Animator animator;
    private InputRooster playerInput;
    void Awake()
    {
        playerInput = new InputRooster();
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimations();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    private void SetAnimations()
    {
        bool jumpPress = playerInput.Chicken.Jump.IsPressed();
        bool duckPress = playerInput.Chicken.Duck.triggered;
        if (jumpPress && !animator.GetBool("Jump"))
        {
            animator.SetBool("Jump", true);
        }
        else if (!jumpPress && animator.GetBool("Jump"))
        {
            animator.SetBool("Jump", false);
        }

        if (duckPress && !animator.GetBool("Duck"))
        {
            animator.SetBool("Duck", true);
        }
        else if (!duckPress && animator.GetBool("Duck"))
        {
            animator.SetBool("Duck", false);
        }
    }

}
