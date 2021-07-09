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
        //increase optimization
       
    }
    void Update()
    {
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
        scoreText.text = "score : "+GameManager.Instance.score.ToString();
    }
    void Resume()
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
