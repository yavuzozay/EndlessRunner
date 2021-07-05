using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(17, 0.5f, 1.5f);
    private float startDelay=1.2f;
    private float repeatDelay=2f;

    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);



    }
    private void Update()
    {
        if (!GameManager.Instance.isGameActive)
            CancelInvoke("SpawnObstacle");
    }

  
    void SpawnObstacle()
    {
    // GameObject tempObstacle;

         Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
      //  tempObstacle.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


    }
}
