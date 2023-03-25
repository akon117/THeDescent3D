using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;
    public Animator animator;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            if(Input.GetKey(KeyCode.S))
            {
                animator.SetBool("Backwards", true);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                animator.SetFloat("Speed", 1);
            }
            isMoving = true;
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * 0.25f * Time.deltaTime * 4;
            //animator.SetFloat("Speed", 1);
            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving = false;
            animator.SetBool("Backwards", false);
            animator.SetFloat("Speed", 0);
        }
    }
}
