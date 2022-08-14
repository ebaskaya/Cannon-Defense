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
    
    public Image[] hearts;
    [SerializeField] int heartIndex = 0;

    public Text ingameScore;
    public Text scoreText;
    private int score = 0;

    private void Awake()
    {
        if(Instance == null) {
            Instance = this;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        gameOverScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    
    void gameOver()
    {
        scoreText.text = score.ToString() + " Points";
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

    public void addScore()
    {
        score += 50;
        ingameScore.text = score.ToString();
    }

}
