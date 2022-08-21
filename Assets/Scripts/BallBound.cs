using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBound : MonoBehaviour
{

    private float xBound = 58.4f;
    private float zBound = 81.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xBound || transform.position.x > xBound)
        {
            GameManager.Instance.destroyCombo();
            Destroy(gameObject);
            
        }
        else if(transform.position.z > zBound)
        {
            GameManager.Instance.destroyCombo();
            Destroy(gameObject);
        }
    }
}
