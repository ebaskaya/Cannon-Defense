using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -65.0f)
        {
            Destroy(gameObject);
            GameManager.Instance.destroyCombo();
            GameManager.Instance.decreaseHealth();
        }
        
    }
}
