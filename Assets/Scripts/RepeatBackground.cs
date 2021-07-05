using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repatWidth;
    void Start()
    {
        startPos = transform.position;
        repatWidth = (GetComponent<BoxCollider>().size.x / (2 *transform.localScale.x));
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < startPos.x-repatWidth )
        {
            transform.position = startPos;

        }
    }
}
