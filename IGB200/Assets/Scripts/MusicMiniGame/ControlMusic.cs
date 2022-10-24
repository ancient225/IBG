using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMusic : MonoBehaviour
{
    [SerializeField] private GameObject Music;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject Normal;
    [SerializeField] private GameObject Pause;

    private bool once;

    [HideInInspector] public bool pause;

    // Start is called before the first frame update
    void Start()
    {
        once = true;
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Buttons();
        
        if (Music.transform.childCount == 0)
        {
            if (once)
            {
                UniversalText.Points += Score.GetComponent<ScorePong>().score;
                End.SetActive(true);
                Panel.SetActive(false);
                once = false;
            }
        }
    }

    void Buttons()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && End.activeInHierarchy != true)
        {
            if (pause)
            {
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
                Pause.SetActive(false);
                Normal.SetActive(true);
            }
            else
            {
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
                Pause.SetActive(true);
                Normal.SetActive(false);
            }
            pause = !pause;
        }
    }
}
