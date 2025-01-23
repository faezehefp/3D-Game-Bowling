using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
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
}