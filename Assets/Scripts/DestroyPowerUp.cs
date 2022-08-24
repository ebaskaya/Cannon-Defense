using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -65.0f)
        {
            Destroy(gameObject);
        }
    }
}
