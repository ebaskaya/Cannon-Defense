using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public RectTransform gameOverScreen;

    public GameObject cannonToss;
    public GameObject rocketSpawner;

    public int maxHealth = 3;
    public int combo = 1;
    
    public Image[] hearts;
    [SerializeField] int heartIndex = 0;

    public Text ingameScore;
    public Text scoreText;
    public Text highScoreText;
    private int score = 0;
    private int highscore;

    private bool havePowerup = false;

    private int powerUpTime = 10;
    private WaitForSeconds powerupTimer = new WaitForSeconds(1);

    public Slider powerupSlider;



    private void Awake()
    {
        if(Instance == null) {
            Instance = this;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        gameOverScreen.gameObject.SetActive(false);
        powerupSlider.value = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void restart()
    {
        SceneManager.LoadScene("game");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void gameOver()
    {
        if (score > highscore)
            PlayerPrefs.SetInt("highscore", score);
        scoreText.text = score.ToString() + " Points";
        highscore = PlayerPrefs.GetInt("highscore");
        highScoreText.text = "Highscore: " + highscore.ToString() + " Points";
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
        Vibration.Vibrate(250);
    }

    public void addScore()
    {
        score += 50 * combo;
        ingameScore.text = score.ToString();
    }

    public void increaseCombo()
    {
        combo++;
    }
    public void destroyCombo()
    {
        combo = 1;
    }

    public void turnOnPowerup()
    {
        havePowerup = true;
        StartCoroutine(powerupCountdown());
    }

    public void turnOffPowerup()
    {
        havePowerup = false;
    }
    public bool getPowerup()
    {
        return havePowerup;
    }

    private IEnumerator powerupCountdown()
    {
        powerupSlider.value = 1;
        for(int i = 0; i < powerUpTime; i++)
        {

            powerupSlider.value = (powerUpTime - i) / 10.0f;
            yield return powerupTimer;
        }
        powerupSlider.value = 0;
        
        turnOffPowerup();
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
