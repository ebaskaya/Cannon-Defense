using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public GameObject rocket;
    public float spawnTime;
    public float spawnDelay;

    private float xRange = 55.0f;
    private float yPos = 5.0f;
    private float zPos = 81.0f;
    private float randomSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Vector3 pos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        Instantiate(rocket, pos, rocket.transform.rotation);
        
        

    }
}
