using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider sliderS;
    [SerializeField] private Slider sliderV;

    [SerializeField] private GameObject Normal;
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject Player;


    private void Start()
    {
        if (sliderS != null)
        {
            if (UniversalText.sensitivity == 0)
            {
                UniversalText.sensitivity = sliderS.value;
            }
            else
            {
                sliderS.value = UniversalText.sensitivity;
            }
        }

        if (UniversalText.volume == 0)
        {
            UniversalText.volume = 0.5f;
        }

        sliderV.value = UniversalText.volume;
    }

    public void Volume(float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        UniversalText.volume = volume;
    }
    public void Sensitivity(float sensitivity)
    {
        UniversalText.sensitivity = sensitivity;
    }
    public void Graphics(int quailty)
    {
        QualitySettings.SetQualityLevel(quailty);
    }
    public void Fullscreen(bool Fullscreen)
    {
        Screen.fullScreen = Fullscreen;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Resume()
    {
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Pause.SetActive(false);
        Normal.SetActive(true);
        if (Player.GetComponent<PlayermoveSnake>() != null)
        {
            Player.GetComponent<PlayermoveSnake>().pause = !Pause;
        }
        else if (Player.GetComponent<PlatformerMove2D>() != null)
        {
            Player.GetComponent<PlatformerMove2D>().pause = !Pause;
        }
        else if (Player.GetComponent<ControlMusic>() != null)
        {
            Player.GetComponent<ControlMusic>().pause = !Pause;
        }
        else if (Player.GetComponent<Movement_script>() != null)
        {
            Player.GetComponent<Movement_script>().pause = !Pause;
        }
    }
}
