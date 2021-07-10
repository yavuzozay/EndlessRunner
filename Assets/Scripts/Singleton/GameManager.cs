using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
   public bool isGameActive;
    public float score;
   // public int level;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        isGameActive = true; 

    }
        
   
     void FixedUpdate()
    {
        ScoreControl();
    }
   private void ScoreControl()
    {
        if (isGameActive)
            score += (Time.deltaTime*2);

        Debug.Log(Time.deltaTime);
        
       


    }

}
