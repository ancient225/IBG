using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("IGB200");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void PlayPong()
    {
        SceneManager.LoadScene("Pong");
    }
    public void PlayPlatformer()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Platformer");
    }
    public void PlaySnake()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Snake");
    }
}
