using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject main;
    [SerializeField] private GameObject Info;
    [SerializeField] private GameObject Opt;


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
        main.SetActive(false);
        Info.SetActive(false);
        Opt.SetActive(true);
    }
    public void Instructions()
    {
        main.SetActive(false);
        Info.SetActive(true);
        Opt.SetActive(false);
    }
    public void MainMenu()
    {
        main.SetActive(true);
        Info.SetActive(false);
        Opt.SetActive(false);
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
    public void PlayMusic()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Music");
    }
}
