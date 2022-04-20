using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverCanvas;

    [SerializeField]
    private GameObject _pause;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        _pause.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        _pause.SetActive(false);
    }
}
