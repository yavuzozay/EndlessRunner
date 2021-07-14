using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsPanel;

    private void Awake()
    {
        controlsPanel.SetActive(false); 
    }
   public void OpenControlsPanel()
    {
        controlsPanel.SetActive(true);
    }

   public void CloseContolsPanel()
    {
        controlsPanel.SetActive(false);

    }
   


}
