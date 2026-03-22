using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public static void LoadHome()
    {
        SceneManager.LoadScene("1_Home");
    }


    public static void LoadSetting()
    {
        SceneManager.LoadScene("2_Setting");
    }


    public static void LoadGame()
    {
        SceneManager.LoadScene("3_Game");
    }


    public static void LoadGameOver()
    {
        SceneManager.LoadScene("4_GameOver");
    }


    public static void LoadCredits()
    {
        SceneManager.LoadScene("5_Credits");
    }


    public static void LoadPauseMenu()
    {
        SceneManager.LoadScene("6_PauseMenu");
    }


    public static void LoadHelp()
    {
        SceneManager.LoadScene("7_Help");
    }

    public static void Exit()
    {
        Application.Quit();
    }
}
