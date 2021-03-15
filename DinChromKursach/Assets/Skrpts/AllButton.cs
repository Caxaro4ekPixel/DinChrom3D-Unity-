using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllButton : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject GameOverPanel;
    //StartMenu
    public void StartButton()
    {
        PlayerPrefs.SetFloat("Speed", 5f);
        SceneManager.LoadScene("Game");
    }
    public void RecordListButton()
    {
        SceneManager.LoadScene("RecordListScene");
    }
    public void LoadButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    //RecordList
    public void BackInStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    //GameButton
    public void PauseButton()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }
    //GamePanelPause
    public void ReturnGame()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetFloat("Speed", 5f);
        SceneManager.LoadScene("Game");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
    //GamePanelGameOver
    public void ORestartGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetFloat("Speed", 5f);
        SceneManager.LoadScene("Game");
    }
}
