using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public RectTransform mainScreen;
    public RectTransform howToPlayScreen;

    private void Start()
    {
        howToPlayScreen.gameObject.SetActive(false);
    }

    public void playGame()
    {
        SceneManager.LoadScene("game");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void returnToMainMenu()
    {
        howToPlayScreen.gameObject.SetActive(false);
        mainScreen.gameObject.SetActive(true);
    }

    public void howToPlay()
    {
        howToPlayScreen.gameObject.SetActive(true);
        mainScreen.gameObject.SetActive(false);
    }
}
