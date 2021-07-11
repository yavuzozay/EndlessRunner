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
    public AudioClip failureClip;
    public AudioClip slideClip;
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
       // Debug.Log(animator.HasState(1,1));

        if (GameManager.Instance.isGameActive)
        { Jump();
        Slide(); }
        else
        {
            dirtParticle.Stop();
            StartCoroutine(GameEnd());
        }
    }
   

    void Slide()
    {
        if ((Input.GetKeyDown(KeyCode.LeftControl)|| Input.GetKeyDown(KeyCode.DownArrow)) && isOnGround)
        {
           
            animator.SetBool("isSliding", true);
            if (!playerAudio.isPlaying)

                playerAudio.PlayOneShot(slideClip, 1.2f);

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
        if((Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow)) &&isOnGround&& !animator.GetBool("isSliding") )
        {
            animator.SetTrigger("Jump");
           
            dirtParticle.Stop();
            if(!playerAudio.isPlaying)
            playerAudio.PlayOneShot(jumpClip, 1.0f);

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
            gameObject.transform.Translate(new Vector3(0, 0, -.15f));
            animator.SetTrigger("Die");
            explosionParticle.Play();
            

        }
    }
    IEnumerator GameEnd()
    {

        BackGroundMusic.Instance.PauseMusic();
        yield return new WaitForSeconds(1.5f);
        if (!playerAudio.isPlaying)
            playerAudio.PlayOneShot(failureClip, 1.0f);
        yield return new WaitForSeconds(2.2f);

        Loader.Instance.LoadResScene();
    }
    IEnumerator waitSlide()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("isSliding", false);

    }
  
   
}
