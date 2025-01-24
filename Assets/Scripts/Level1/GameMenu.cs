using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public GameObject LevelMenu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(LevelMenu.activeSelf)
            {
                LevelMenu.SetActive(false);
            }
            else
            {
                LevelMenu.SetActive(true);
            }
        }
    }

    //تابع دکمه ریستارت
    public void RestartGame()
    {
        //لود مجدد همین صحنه
        SceneManager.LoadScene("Level1");
    }

    //تابع دکمه رفتن به منوی اصلی
    public void GoToMainMenu()
    {
        //لود کردن سین منوی اصلی
        SceneManager.LoadScene("MainMenu");
       
    }

    //تابع خروج از بازی
    public void QuitGame()
    {
        //بستن برنامه
        Application.Quit();
    }
}