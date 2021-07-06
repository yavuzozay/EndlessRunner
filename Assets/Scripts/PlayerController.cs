﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody playerRB;
    bool isOnGround;
    public bool gameOver;
    private void Awake()
    {
        isOnGround = true;
        playerRB = GetComponent<Rigidbody>();
       animator= GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Slide();
    }

    void Slide()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isOnGround)
        {
            animator.SetTrigger("Slide");
           
        }
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&isOnGround)
        {
            animator.SetTrigger("Jump");
            playerRB.AddForce(Vector3.up*5, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ground"))
            isOnGround = true;
       else  if (collision.collider.CompareTag("obstacle"))
        {
            GameManager.Instance.isGameActive = false;
            gameObject.transform.Translate(new Vector3(0, 0, -.5f));
            animator.SetTrigger("Die");

        }
    }

}
