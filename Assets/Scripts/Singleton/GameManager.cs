using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
   public bool isGameActive;
    public float score;
    public float difficulty;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        isGameActive = true;
        difficulty = 1f;
    }
        
   
     void FixedUpdate()
    {
        ScoreControl();
    }
   private void ScoreControl()
    {
        if (isGameActive)
            score += (Time.deltaTime*2.2f);

       
        
       


    }

}
