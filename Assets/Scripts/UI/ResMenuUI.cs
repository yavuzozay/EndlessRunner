using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResMenuUI : MonoBehaviour
{
    [SerializeField]  Text scoreTxt;
    

    private void Awake()
    {
 
        scoreTxt.text = "Score : " + GameManager.Instance.score.ToString();

    }

  public void GoToGameScene()
    {
        Loader.Instance.LoadGameMenu();

    }

}
