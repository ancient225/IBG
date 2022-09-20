using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerPong : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [HideInInspector] public float Timer;
    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject End;

    // Start is called before the first frame update
    void Start()
    {
        info = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        Timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        info.text = "Timer: " + Mathf.RoundToInt(Timer) + "";

        if (Timer <= 0)
        {
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            End.SetActive(true);
        }
    }
}
