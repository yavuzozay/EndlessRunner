using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsPanel;
  
    void OpenControlsPanel()
    {
        controlsPanel.SetActive(true);
    }

    void CloseContolsPanel()
    {
        controlsPanel.SetActive(true);

    }


}
