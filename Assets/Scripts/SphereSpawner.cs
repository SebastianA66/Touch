using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spawner;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public int spawnLimit = 5;
    public int currentSpawnCount = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {
        Instantiate(spawner, transform.position, transform.rotation);
        currentSpawnCount++;
    }

    private void Update()
    {
        
        if (currentSpawnCount >= spawnLimit)
        {
            
            CancelInvoke("SpawnObject");
        }
    }
}
