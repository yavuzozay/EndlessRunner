using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
   public bool isGameActive;
    public int score;
   // public int level;
    private void Awake()
    {
        isGameActive = true; 
    }
        
   
     void FixedUpdate()
    {
        ScoreControl();
    }
   private void ScoreControl()
    {
        if(isGameActive)
            score = (int)(Time.time*2);
        //score=(int)(Time.time*level);


    }

}
