using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> obstaclePrefabs;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    private float startDelay = 3f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int randomObstacleIndex = Random.Range(0, obstaclePrefabs.Count);
            Instantiate(obstaclePrefabs[randomObstacleIndex], spawnPos, obstaclePrefabs[randomObstacleIndex].transform.rotation);
        }
    }
}
