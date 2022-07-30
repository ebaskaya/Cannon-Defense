using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonToss : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject ballPrefab;

    Plane basePlane = new Plane(-Vector3.forward, new Vector3(0, 0, 5));

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0)
        {
            
            Touch touch = Input.GetTouch(0);
            

            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 124.2f)); 

            Debug.Log(worldPosition);

            

            if (touch.phase == TouchPhase.Began)
                Instantiate(ballPrefab, worldPosition, Quaternion.identity);
        }
       

        
    }
        
}

