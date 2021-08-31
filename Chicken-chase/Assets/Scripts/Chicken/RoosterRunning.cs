using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterRunning : MonoBehaviour
{
    private Animator animator;
    protected InputRooster playerInput;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInput = new InputRooster();
    }

    // Update is called once per frame
    void Update()
    {
        bool jumpPress = playerInput.Chicken.Jump.triggered;
        if (jumpPress)
        {
            animator.SetBool("Jump", true);
        }
        
    }


}
