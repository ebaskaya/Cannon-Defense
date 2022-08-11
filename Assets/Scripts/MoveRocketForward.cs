using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocketForward : MonoBehaviour
{
    

    
    private float randomSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(20, 40);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * randomSpeed);
        
        
    }
}
