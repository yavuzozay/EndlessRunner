using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private BoxCollider2D boxCollider2D;
    private Vector3 startPos;
    private float repatWidth;
    private void Awake()
    {
        startPos = transform.position;
        boxCollider2D = GetComponent<BoxCollider2D>();
       
    }
    private void Start()
    {
        repatWidth = boxCollider2D.size.x;
       

    }
    private void Update()
    {
     
    }
    private void FixedUpdate()
    {
        if (transform.position.x < startPos.x - repatWidth)
        {
            transform.position = startPos;
        }
    }

    // Update is called once per frame
    /* void FixedUpdate()
     {
         GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time*3), 0f);

     }*/
}
