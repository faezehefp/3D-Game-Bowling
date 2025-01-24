using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] HighScore highScore;
    [SerializeField] TextMeshProUGUI highScoreValue;
    [SerializeField] GameObject highScoreMenu;

    //تابع دکمه پلی
    public void LoadLevel1Scene()
    {
        //لود صحنه دوم یعنی لول اول
        SceneManager.LoadScene("Level1");
    }

    //تابع دکمه خروج
    public void ExitGame()
    {
        //بستن بازی
        Application.Quit();
    }

    public void ShowHighScore()
    {
        highScoreMenu.SetActive(true);
        highScoreValue.text = highScore.highScore.ToString();
    }

    public void CloseHighScore()
    {
        highScoreMenu.SetActive(false);
    }

    public void ResetHighScore()
    {
        highScore.highScore = 0;
        highScoreValue.text = highScore.highScore.ToString();
    }
}