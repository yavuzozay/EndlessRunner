using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoSingleton<Loader>
{

    public int result;
   void Load(int sceneInd)
    {
        SceneManager.LoadScene(sceneInd);

    }
    void LoadMainMenu()
    {
        Load(0);
    }
    void LoadGameMenu()
    {
        Load(1);
    }
  public  void LoadResScene()
    {
        result = GameManager.Instance.score;
        Load(2);
    }
   
}
