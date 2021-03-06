using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0.5f, 1.5f);
    private float startDelay=0f;
    private float repeatDelay=2f;
    int random;

    
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

        random = Random.RandomRange(0,2);
       
        switch (random)
        {
            case 0: spawnPos = new Vector3(25, 0.5f, 1.5f); break;
            case 1: spawnPos= new Vector3(25, 1.5f, 1.5f); break;
        }
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
      //  tempObstacle.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


    }
}
