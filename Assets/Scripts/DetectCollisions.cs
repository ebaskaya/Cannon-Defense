using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.name == "Powerup(Clone)")
            GameManager.Instance.turnOnPowerup();

        Instantiate(explosion, other.transform.position, Quaternion.identity);
        
        Destroy(gameObject);
        Destroy(other.gameObject);

        

        GameManager.Instance.increaseCombo();
        GameManager.Instance.addScore();
    }
}
