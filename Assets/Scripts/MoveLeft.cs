using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{


    [SerializeField] private float speed = 30;
    void Update()
    {
        if(GameManager.Instance.isGameActive)
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
