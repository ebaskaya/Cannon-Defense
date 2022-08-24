using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 30.0f;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.getPowerup() == true)
            speed = 150;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //Vectro3 forwardd
    }
}
