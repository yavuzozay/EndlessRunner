using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuSc : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private bool GameIsPaused;
    [SerializeField] private GameObject pauseMenuUI;
    AudioSource music;
    void Awake()
    {
        pauseMenuUI.SetActive(false);
       //GameManager.Instance.score = 0;
        Time.timeScale = 1f;

    }
    void Update()
    {
       // Debug.Log("dif:"+GameManager.Instance.difficulty);
        if (Input.GetKeyDown(KeyCode.Escape)&&GameManager.Instance.isGameActive)
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();

          
        }
    }
  void FixedUpdate()
    {
        scoreText.text = "score : "+((int)(GameManager.Instance.score)).ToString();
    }
   public void Resume()
    {

        pauseMenuUI.SetActive(false);
        BackGroundMusic.Instance.ResumeMusic();
        Time.timeScale = 1f;
        GameIsPaused = false;

      //  GameManager.Instance.isGameActive = true;

    }
   
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        BackGroundMusic.Instance.PauseMusic();
        GameIsPaused = true;
     //   GameManager.Instance.isGameActive = false;
    }

}
