using System.Collections;
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
        Jump();
        Slide();
        if (!GameManager.Instance.isGameActive)
            dirtParticle.Stop();
    }

    void Slide()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isOnGround)
        {
            animator.SetTrigger("Slide");
            //dirtParticle.Stop();
          
           
        }
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&isOnGround&& GameManager.Instance.isGameActive)
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

}
