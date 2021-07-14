using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoSingleton<Loader>
{

   
   void Load(int sceneInd)
    {
        SceneManager.LoadScene(sceneInd);

    }
    public void LoadMainMenu()
    {
        Load(0);
        GameManager.Instance.difficulty = 1f;

    }
    public void LoadGameMenu()
    {
        GameManager.Instance.isGameActive = true;
        GameManager.Instance.score = 0;
        Load(1);
    }
  public  void LoadResScene()
    {
       
        Load(2);
    }
   
}
