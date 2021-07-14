using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{


    [SerializeField] private float speed = 30;
    private float zorluk;
    private void Awake()
    {
        zorluk = GameManager.Instance.difficulty;
      
        if(GameManager.Instance.score<100)
            speed += GameManager.Instance.score/100;
        else
            speed += GameManager.Instance.score / 40 +.1f;


        //  Debug.Log(speed);


    }

    private void LateUpdate()
    {
     
        if (GameManager.Instance.isGameActive)
        {
               
            transform.Translate(Vector3.left * Time.deltaTime * speed * zorluk);
            Debug.Log( speed*zorluk);

        }
    }
}
