using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag!="ground")
        Destroy(collision.gameObject);
    }
}
