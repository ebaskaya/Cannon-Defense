using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonToss : MonoBehaviour
{
    private bool shoot;

    public Slider reloadBar;
    private int maxProgress = 100;
    private int currentProgress;

    private WaitForSeconds reloadTick = new WaitForSeconds(0.13f);

    private Camera mainCamera;
    public GameObject ballPrefab;
    public Vector3 ballDirection;

    Plane basePlane = new Plane(-Vector3.forward, new Vector3(0, 0, 5));

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        shoot = true;
        reloadBar.value = 1;


    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0 && shoot != false)
        {
            
            Touch touch = Input.GetTouch(0);
            

            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 124.2f)); 

            Debug.Log(worldPosition);

            ballDirection = new Vector3(worldPosition.x - transform.position.x, 0, worldPosition.z - transform.position.z);
            

            float angle = Vector3.Angle(ballDirection, Vector3.forward);
            if (worldPosition.x < 0)
                angle = -angle;

            
            Debug.Log(angle);

            if (touch.phase == TouchPhase.Began)
            {
                Instantiate(ballPrefab, transform.position, Quaternion.Euler(0, angle, 0));
                StartCoroutine(reload());
                
            }
        }
       

        
    }

    private IEnumerator reload()
    {
        shoot = false;
        currentProgress = 0;
        while(currentProgress < maxProgress)
        {
            currentProgress += maxProgress / 5;
            reloadBar.value = currentProgress / 100;
            yield return reloadTick;
            Debug.Log(currentProgress);
        }
        shoot = true;
        
    }
        
}

