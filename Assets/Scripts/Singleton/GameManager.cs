using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
   public bool isGameActive;
    private void Awake()
    {
        isGameActive = true; 
    }

    
  
}
