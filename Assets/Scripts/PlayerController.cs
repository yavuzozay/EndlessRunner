﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody playerRB;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpClip;
    bool isOnGround;
    public bool gameOver;
    private void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
        isOnGround = true;
        playerRB = GetComponent<Rigidbody>();
       animator= GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(animator.HasState(1,1));

        if (GameManager.Instance.isGameActive)
        { Jump();
        Slide(); }
        else
        {
            dirtParticle.Stop(); 
        }
    }

    void Slide()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isOnGround)
        {
           
            animator.SetBool("isSliding", true);
            StartCoroutine(waitSlide());
            
            
            //dirtParticle.Stop();


        }
      /*  if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("isSliding", false);
        }*/
            
       
          

    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&isOnGround&& !animator.GetBool("isSliding") )
        {
            playerAudio.PlayOneShot(jumpClip,1.0f);
            animator.SetTrigger("Jump");
           
            dirtParticle.Stop();
           // animator.Get
            playerRB.AddForce(Vector3.up*5.5f, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else  if (collision.collider.CompareTag("obstacle"))
        {
            dirtParticle.Stop();
            GameManager.Instance.isGameActive = false;
            gameObject.transform.Translate(new Vector3(0, 0, -.5f));
            animator.SetTrigger("Die");
            explosionParticle.Play();

        }
    }

    IEnumerator waitSlide()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("isSliding", false);

    }
  
   
}
