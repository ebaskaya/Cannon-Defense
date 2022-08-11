using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public RectTransform gameOverScreen;

    public GameObject cannonToss;
    public GameObject rocketSpawner;

    public int maxHealth = 3;
    //public int currentHealth;
    public Image[] hearts;
    [SerializeField] int heartIndex = 0;

    private void Awake()
    {
        if(Instance == null) {
            Instance = this;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //currentHealth = maxHealth;
        gameOverScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    
    void gameOver()
    {
        
        gameOverScreen.gameObject.SetActive(true);
        Destroy(cannonToss);
        Destroy(rocketSpawner);
        Debug.Log("Game Over");
    }
    
    public void decreaseHealth()
    {
        
        hearts[heartIndex].enabled = false;
        heartIndex++;
        if(heartIndex >= 3)
        {
            Invoke("gameOver", 0);
            
        }
    }

}
