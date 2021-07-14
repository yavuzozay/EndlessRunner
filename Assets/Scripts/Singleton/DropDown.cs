using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    // Start is called before the first frame update
    public void HandleInputData(int val)
    {
        switch (val)
        {
            case 0: GameManager.Instance.difficulty=1f; break;
            case 1: GameManager.Instance.difficulty = 1.5f; break;
            case 2: GameManager.Instance.difficulty = 1.85f; break;
           // default: GameManager.Instance.difficulty = 1f; break;

        }
    }
}
