using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public GameObject powerup;
    public GameObject rocket;
    public float spawnTime;
    public float spawnDelay;

    private float xRange = 55.0f;
    private float yPos = 5.0f;
    private float zPos = 81.0f;
    private float randomNumber;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        randomNumber = Random.Range(0, 10);
        Vector3 pos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        if(randomNumber >= 8 && GameManager.Instance.getPowerup() != true && 
            (GameObject.Find("Powerup(Clone)") == null))
            Instantiate(powerup, pos, powerup.transform.rotation);
        else
            Instantiate(rocket, pos, rocket.transform.rotation);
    }
}
